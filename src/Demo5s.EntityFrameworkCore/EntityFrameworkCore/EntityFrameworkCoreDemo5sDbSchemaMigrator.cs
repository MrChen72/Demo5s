using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Demo5s.Data;
using Volo.Abp.DependencyInjection;

namespace Demo5s.EntityFrameworkCore
{
    public class EntityFrameworkCoreDemo5sDbSchemaMigrator
        : IDemo5sDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDemo5sDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Demo5sDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Demo5sDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
