using System;
using System.Collections.Generic;
using System.Text;
using Demo5s.Localization;
using Volo.Abp.Application.Services;

namespace Demo5s
{
    /* Inherit your application services from this class.
     */
    public abstract class Demo5sAppService : ApplicationService
    {
        protected Demo5sAppService()
        {
            LocalizationResource = typeof(Demo5sResource);
        }
    }
}
