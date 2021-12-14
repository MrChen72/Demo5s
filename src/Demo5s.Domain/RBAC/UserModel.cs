using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.RBAC
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserModel : BasicAggregateRoot<Guid>
    {
        public string UserName { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string UserHeadPortrait { get; set; }//用户头像
    }
}
