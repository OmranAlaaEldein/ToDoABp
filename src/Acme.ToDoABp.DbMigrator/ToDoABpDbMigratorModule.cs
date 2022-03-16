using Acme.ToDoABp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.ToDoABp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ToDoABpEntityFrameworkCoreModule),
        typeof(ToDoABpApplicationContractsModule)
        )]
    public class ToDoABpDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
