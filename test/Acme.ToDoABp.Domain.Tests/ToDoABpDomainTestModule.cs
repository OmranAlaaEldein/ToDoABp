using Acme.ToDoABp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.ToDoABp
{
    [DependsOn(
        typeof(ToDoABpEntityFrameworkCoreTestModule)
        )]
    public class ToDoABpDomainTestModule : AbpModule
    {

    }
}