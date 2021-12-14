using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.RBAC
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class RoleModel : BasicAggregateRoot<Guid>
    {
        public string RoleName { get; set; } //名称
        public string RoleDetail { get; set; }//详情
    }
}
