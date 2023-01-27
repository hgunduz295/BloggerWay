﻿using AutoMapper;
using BloggerWay.Entities.ComplexTypes;
using BloggerWay.Entities.Dtos;
using BloggerWay.MVC.Areas.Admin.Models;
using BloggerWay.MVC.Helpers.Abstract;
using BloggerWay.Services.Abstract;
using BloggerWay.Shared.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BloggerWay.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IImageHelper _imageHelper;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper, IImageHelper imageHelper)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
            _imageHelper = imageHelper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _articleService.GetAllByNonDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var result = await _categoryService.GetAllByNonDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(new ArticleAddViewModel
                {
                    Categories = result.Data.Categories
                });
            }

            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddViewModel articleAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var articleAddDto = _mapper.Map<ArticleAddDto>(articleAddViewModel);
                var imageResult = await _imageHelper.Upload(articleAddViewModel.Title,
                    articleAddViewModel.ThumbnailFile, PictureType.Post);
                articleAddDto.Thumbnail = imageResult.Data.FullName;
                var result = await _articleService.AddAsync(articleAddDto, "Ali Veli");
                if (result.ResultStatus == ResultStatus.Success)
                {
                    TempData.Add("SuccessMessage", result.Message);
                    return RedirectToAction("Index", "Article");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View(articleAddViewModel);
                }
            }

            return View(articleAddViewModel);
        }

    }
}
