﻿using System;
using System.Threading.Tasks;

namespace BloggerWay.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }

        Task<int> SaveAsync();

    }
}
