using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProductCatalog.Infrastructure.Data.Common
{
    public interface IRepository : IDisposable
    {
        IQueryable<T> All<T>() where T : class;

        void Add<T>(T entity) where T : class;

        T GetById<T>(object id) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(object id) where T : class;

        void Delete<T>(T entity) where T : class;

        int SaveChanges();
        DbSet<T> DbSet<T>() where T : class;
    }
}
