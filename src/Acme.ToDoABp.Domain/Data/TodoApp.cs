using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.ToDoABp
{
    public class TodoApp: BasicAggregateRoot<Guid>
    {
        public string Text { set; get; }
    }
}
