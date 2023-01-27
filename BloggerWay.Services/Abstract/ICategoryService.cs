﻿using BloggerWay.Entities.Concrete;
using BloggerWay.Entities.Dtos;
using BloggerWay.Shared.Utilities.Results.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloggerWay.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> Get(int categoryId);
        Task<IDataResult<IList<Category>>> GetAll();
        Task<IDataResult<IList<Category>>> GetAllByNonDeleted();

        Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);

        Task<IResult> Delete(int categoryId, string modifiedByName);
        Task<IResult> HardDelete(int categoryId);
    }
}