using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto.RBACDto
{
    /// <summary>
    /// 用户角色表Dto
    /// </summary>
    public class UserRoleModelDto : AuditedEntityDto<Guid>
    {
        public string UserId { get; set; }//用户外键
        public string RoleId { get; set; }//角色外键
    }
}
