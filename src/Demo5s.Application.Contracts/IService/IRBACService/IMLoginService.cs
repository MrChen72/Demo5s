using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo5s.IService.IRBACService
{
    public interface IMLoginService :IApplicationService
    {
        Task<ResData<string>> Login(string userName, string userPwd);
    }
}
