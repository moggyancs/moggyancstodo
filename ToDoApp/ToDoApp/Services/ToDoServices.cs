using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class ToDoServices : ICrudRepository<ToDo>
    {
        public Task CreateAsync(ToDo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToDo>> GetAllAsync(IQueryCollection q)
        {
            throw new NotImplementedException();
        }

        public Task<ToDo> GettByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task LoadContextAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ToDo entity)
        {
            throw new NotImplementedException();
        }
    }
}
