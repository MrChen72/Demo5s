
using Demo5s.IService.IRBACService;
using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Demo5s.Service.RBACService
{
    /// <summary>
    /// IDs4验证配置文件
    /// </summary>
    public class MIds4Service : IMIds4Service
    {
        private IConfiguration _configuration;
        public MIds4Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        ///  获取系统token
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPwd"></param>
        /// <returns></returns>
        public async Task<string> GetIdsTokenAsync(string userName, string userPwd)
        {
            var client = new HttpClient();

            var idsTokenUrl = _configuration.GetSection("AuthServer:Authority").Value;
            var AppClientId = _configuration.GetSection("AuthServer:AppClientId").Value;
            var AppClientSecret = _configuration.GetSection("AuthServer:AppClientSecret").Value;

            var disco = client.GetDiscoveryDocumentAsync(idsTokenUrl);

            var tokenResponse = await client.RequestPasswordTokenAsync(
                new PasswordTokenRequest
                {
                    Address = disco.Result.TokenEndpoint,
                    ClientId = AppClientId,
                    ClientSecret = AppClientSecret,
                    UserName = userName,
                    Password = userPwd
                });

            if (tokenResponse.IsError)
            {
                return string.Empty;
            }

            return tokenResponse.AccessToken;
        }
    }
}
