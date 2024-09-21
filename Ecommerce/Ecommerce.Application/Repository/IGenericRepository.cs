using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface IGenericRepository <TEntity> where TEntity : class
    {

        // GET
        // Grid View
        public Task<IEnumerable<TEntity>> GetAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        int? page = null,
        int pageSize = 10,
        bool noTrack = false,
        List<Expression<Func<TEntity, object>>>? includeProperties = null
        );


        // GET BY 
        public Task<TEntity> GetByAsync(
        Expression<Func<TEntity, bool>> filter,
        bool noTrack = false,
        List<Expression<Func<TEntity, object>>>? includeProperties = null);



        // Create
        public void Create(TEntity entity);


        // Update
        public void Update(TEntity entity);


        // Delete
        public void Delete(TEntity entity);

    }
}
