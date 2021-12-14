using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationRBACDto
{
    /// <summary>
    /// 验证用户表Dto
    /// </summary>
    public class UserValidationDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserHeadPortrait { get; set; }//用户头像
    }
}
