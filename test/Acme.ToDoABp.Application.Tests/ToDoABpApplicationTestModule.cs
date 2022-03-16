using Volo.Abp.Modularity;

namespace Acme.ToDoABp
{
    [DependsOn(
        typeof(ToDoABpApplicationModule),
        typeof(ToDoABpDomainTestModule)
        )]
    public class ToDoABpApplicationTestModule : AbpModule
    {

    }
}