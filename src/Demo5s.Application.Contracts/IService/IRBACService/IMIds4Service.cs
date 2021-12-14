using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo5s.IService.IRBACService
{
    public interface IMIds4Service
    {
        public Task<string> GetIdsTokenAsync(string userName, string userPwd);
    }
}
