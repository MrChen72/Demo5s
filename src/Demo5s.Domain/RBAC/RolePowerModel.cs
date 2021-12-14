using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.RBAC
{
    /// <summary>
    /// 角色权限表
    /// </summary>
    public class RolePowerModel : BasicAggregateRoot<Guid>
    {
        public string PowerId { get; set; } //权限表
        public string RoleId { get; set; }//角色表
    }
}
