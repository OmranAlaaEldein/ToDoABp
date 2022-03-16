using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;


namespace Acme.ToDoABp
{
    public interface ITodoAppService : IApplicationService
    {
        Task<List<TodoAppDto>> GetListAsync();
        Task<TodoAppDto> CreateAsync(string text);
        Task DeleteAsync(Guid id);
    }
}
