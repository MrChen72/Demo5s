using Demo5s.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Demo5s.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Demo5sController : AbpController
    {
        protected Demo5sController()
        {
            LocalizationResource = typeof(Demo5sResource);
        }
    }
}