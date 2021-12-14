using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationRBACDto
{
    /// <summary>
    /// 验证角色表Dto
    /// </summary>
    public class RoleValidationDto
    {
        [Required]
        public string RoleName { get; set; } //名称
        [Required]
        public string RoleDetail { get; set; }//详情
    }
}
