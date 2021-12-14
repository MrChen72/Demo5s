using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationRBACDto
{
    /// <summary>
    /// 验证权限表Dto
    /// </summary>
    public class PowerValidationDto
    {
        [Required]
        public string PowerName { get; set; }  //名称
        [Required]
        public string PowerDetail { get; set; } //详情
    }
}
