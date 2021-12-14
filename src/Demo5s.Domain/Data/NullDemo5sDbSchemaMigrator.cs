using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Demo5s.Data
{
    /* This is used if database provider does't define
     * IDemo5sDbSchemaMigrator implementation.
     */
    public class NullDemo5sDbSchemaMigrator : IDemo5sDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}