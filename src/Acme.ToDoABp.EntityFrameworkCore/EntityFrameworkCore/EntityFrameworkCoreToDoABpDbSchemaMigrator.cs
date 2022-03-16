using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.ToDoABp.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.ToDoABp.EntityFrameworkCore
{
    public class EntityFrameworkCoreToDoABpDbSchemaMigrator
        : IToDoABpDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreToDoABpDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ToDoABpDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ToDoABpDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
