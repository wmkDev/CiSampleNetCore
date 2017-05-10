using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiSampleNetCore.Contracts;
using CiSampleNetCore.Data.EfContext;
using CiSampleNetCore.Entities;
using CiSampleNetCore.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace CiSampleNetCore.Services
{
    public class TodoService : ITodoService
    {
        private readonly IDataContext _dataContext;

        public TodoService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<TodoViewModel>> GetAllAsync()
        {
            var query = _dataContext.Todos.AsQueryable();

            //filter and logics:
            //query = query.Where(w => w.Id == 0);

            var todos = await query.OrderBy(t => t.Id)
                                   .Select(todo => MapTodoVm(todo))
                                   .ToListAsync();
            return todos;
        }

        private static TodoViewModel MapTodoVm(Todo todo)
        {
            return new TodoViewModel
            {
                Date = todo.Date,
                Title = todo.Title
            };
        }
    }
}
