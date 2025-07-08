using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess;

public interface IGenericRespositoryAsync<T> where T : class, IEntity, new()
{
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task <T> GetAsync(Expression<Func<T, bool>> filter);
    Task <List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
    IQueryable<T> GetQuaryableAsync(Expression<Func<T, bool>>? filter = null);
}
