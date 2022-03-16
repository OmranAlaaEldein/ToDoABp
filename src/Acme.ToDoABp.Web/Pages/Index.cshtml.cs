using System.Collections.Generic;
using System.Threading.Tasks;

namespace Acme.ToDoABp.Web.Pages
{
    public class IndexModel : ToDoABpPageModel
    {
        public List<TodoAppDto> TodoItems { get; set; }

        private readonly ITodoAppService _todoAppService;

        public IndexModel(ITodoAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }

        public async Task OnGetAsync()
        {
            TodoItems = await _todoAppService.GetListAsync();
        }
    }
}