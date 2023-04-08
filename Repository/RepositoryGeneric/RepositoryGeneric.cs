using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.RepositoryGeneric
{
    public abstract class RepositoryGeneric<T> : IRepositoryGeneric<T> where T : class
    {
        protected RepositoryContext RepositoryContext;
        public RepositoryGeneric(RepositoryContext repositoryContext) 
        => RepositoryContext = repositoryContext; 
        public IQueryable<T> FindAll(bool trackChanges) 
        => !trackChanges 
            ? RepositoryContext.Set<T>()
            .AsNoTracking() // Cuando se establece en falso, adjunta AsNoTracking informa a EF Core que no necesita realizar un seguimiento de los cambios para las entidades requeridas. esto en gran medida mejora la velocidad de una consulta.
            : RepositoryContext.Set<T>(); 

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, 
        bool trackChanges) => 
        !trackChanges 
            ? RepositoryContext.Set<T>() 
            .Where(expression) 
            .AsNoTracking() 
            : RepositoryContext.Set<T>() 
            .Where(expression); 
        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity); 
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity); 
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
        
    }
}