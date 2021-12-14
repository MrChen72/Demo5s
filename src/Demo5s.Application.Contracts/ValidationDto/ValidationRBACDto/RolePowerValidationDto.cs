using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationRBACDto
{
    /// <summary>
    /// 验证角色权限表Dto
    /// </summary>
    public class RolePowerValidationDto
    {
        [Required]
        public string PowerId { get; set; } //权限表
        [Required]
        public string RoleId { get; set; }//角色表
    }
}
