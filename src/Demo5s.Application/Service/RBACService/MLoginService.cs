
using Demo5s.Enums;
using Demo5s.IService.IRBACService;
using Microsoft.Extensions.Configuration;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo5s.Service.RBACService
{
    /// <summary>
    /// 登录 +IDS4验证
    /// </summary>
    public class MLoginService : ApplicationService, IMLoginService
    {

        private IConfiguration configuration;

        public MLoginService(IConfiguration _configuration)
        {
            configuration = _configuration;
        }


        public async Task<ResData<string>> Login(string userName, string userPwd)
        {
            MIds4Service mIds4Service = new MIds4Service(configuration);

            string token = await mIds4Service.GetIdsTokenAsync(userName, userPwd);

            return new ResData<string>()
            {
                State = BusinessType.succeed,
                Message = "登录成功",
                Data = token
            };
        }
    }
}
