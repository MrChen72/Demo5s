using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Demo5s
{
    [Dependency(ReplaceServices = true)]
    public class Demo5sBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Demo5s";
    }
}
