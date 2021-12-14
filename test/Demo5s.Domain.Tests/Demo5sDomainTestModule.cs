using Demo5s.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Demo5s
{
    [DependsOn(
        typeof(Demo5sEntityFrameworkCoreTestModule)
        )]
    public class Demo5sDomainTestModule : AbpModule
    {

    }
}