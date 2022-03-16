using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.ToDoABp
{
    public class TodoAppService : ApplicationService, ITodoAppService
    {
        private readonly IRepository<TodoApp, Guid> _todoItemRepository;

        public TodoAppService(IRepository<TodoApp, Guid> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public async Task<List<TodoAppDto>> GetListAsync()
        {
            var items = await _todoItemRepository.GetListAsync();
            return items
                .Select(item => new TodoAppDto
                {
                    Id = item.Id,
                    Text = item.Text
                }).ToList();
        }
        public async Task<TodoAppDto> CreateAsync(string text)
        {
            var todoItem = await _todoItemRepository.InsertAsync(
                new TodoApp { Text = text }
            );

            return new TodoAppDto
            {
                Id = todoItem.Id,
                Text = todoItem.Text
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _todoItemRepository.DeleteAsync(id);
        }

    }
}
