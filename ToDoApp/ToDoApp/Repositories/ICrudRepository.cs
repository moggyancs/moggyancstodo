using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoApp.Services
{
    public interface ICrudRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(IQueryCollection q);
        Task CreateAsync(T entity);
        Task<T> GettByIdAsync(long id);
        Task UpdateAsync(T entity);
        Task DeleteByIdAsync(long id);

        Task LoadContextAsync();
    }
}

