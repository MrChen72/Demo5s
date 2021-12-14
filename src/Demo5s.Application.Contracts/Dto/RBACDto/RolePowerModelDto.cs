using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto.RBACDto
{
    /// <summary>
    /// 角色权限表Dto
    /// </summary>
    public class RolePowerModelDto : AuditedEntityDto<Guid>
    {
        public string PowerId { get; set; } //权限表
        public string RoleId { get; set; }//角色表
    }
}
