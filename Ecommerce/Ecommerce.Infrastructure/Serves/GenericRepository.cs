using Ecommerce.Application.Repository;
using Ecommerce.Infrastructure.Presistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Serves
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        private readonly ApplicationContext context;

        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
        }


        public async Task<IEnumerable<TEntity>> GetAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        int? page = null,
        int pageSize = 10,
        bool noTrack = false,
        List<Expression<Func<TEntity, object>>>? includeProperties = null)
        {
            IQueryable<TEntity> query = context.Set<TEntity>();

            if (filter != null)
            {
                query = query.Where(filter);
            }


            if (page.HasValue && page > 0)
            {
                query = query.Skip((page.Value - 1) * pageSize).Take(pageSize);
            }

            if (noTrack)
            {
                query = query.AsNoTracking();
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }


            return await query.ToListAsync();
        }


        public async Task<TEntity> GetByAsync(Expression<Func<TEntity, bool>> filter,
              bool noTrack = false,
              List<Expression<Func<TEntity, object>>>? includeProperties = null)
        {

            IQueryable<TEntity> query = context.Set<TEntity>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            if (noTrack)
            {
                query = query.AsNoTracking();
            }


            return await query.FirstOrDefaultAsync();
        }


        public void Create(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }





    }
}
