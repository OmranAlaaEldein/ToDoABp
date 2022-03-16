using System.Threading.Tasks;

namespace Acme.ToDoABp.Data
{
    public interface IToDoABpDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
