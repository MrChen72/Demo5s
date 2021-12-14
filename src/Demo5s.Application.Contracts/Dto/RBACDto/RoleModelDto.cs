using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto.RBACDto
{
    /// <summary>
    /// 角色表Dto
    /// </summary>
    public class RoleModelDto : AuditedEntityDto<Guid>
    {
        public string RoleName { get; set; } //名称
        public string RoleDetail { get; set; }//详情
    }
}
