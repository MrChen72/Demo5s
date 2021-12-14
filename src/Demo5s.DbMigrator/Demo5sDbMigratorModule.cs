using Demo5s.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Demo5s.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Demo5sEntityFrameworkCoreModule),
        typeof(Demo5sApplicationContractsModule)
        )]
    public class Demo5sDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
