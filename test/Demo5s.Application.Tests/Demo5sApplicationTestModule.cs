using Volo.Abp.Modularity;

namespace Demo5s
{
    [DependsOn(
        typeof(Demo5sApplicationModule),
        typeof(Demo5sDomainTestModule)
        )]
    public class Demo5sApplicationTestModule : AbpModule
    {

    }
}