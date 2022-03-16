using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.ToDoABp.Data
{
    /* This is used if database provider does't define
     * IToDoABpDbSchemaMigrator implementation.
     */
    public class NullToDoABpDbSchemaMigrator : IToDoABpDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}