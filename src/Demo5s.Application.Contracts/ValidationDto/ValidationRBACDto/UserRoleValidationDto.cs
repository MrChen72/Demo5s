using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationRBACDto
{
    /// <summary>
    /// 验证用户角色表Dto
    /// </summary>
    public class UserRoleValidationDto
    {
        [Required]
        public string UserId { get; set; }//用户外键
        [Required]
        public string RoleId { get; set; }//角色外键
    }
}
