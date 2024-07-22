using HepsiApi.Application.Interfaces.Repositories;
using HepsiApi.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class ,IEntityBase,new()
    {
        private readonly DbContext dbContext;
        public ReadRepository(DbContext dbContext) { this.dbContext = dbContext;  }
        private DbSet<T> Table { get => dbContext.Set<T>(); }
        public Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            IQueryable<T> query =Table
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentPage = 1, int pageSize = 3)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            throw new NotImplementedException();
        }
    }

}
    
    
}
