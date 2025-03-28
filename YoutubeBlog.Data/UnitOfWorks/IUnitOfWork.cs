﻿using YoutubeBlog.Core.Entities;
using YoutubeBlog.Data.Repositories.Abstractions;

namespace YoutubeBlog.Data.UnitOfWorks
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class,IEntityBase,new();
        Task<int> SaveAsync();
        int Save();
    }
}
