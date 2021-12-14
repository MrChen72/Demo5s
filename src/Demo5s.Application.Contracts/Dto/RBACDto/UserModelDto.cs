using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto.RBACDto
{
    /// <summary>
    /// 用户表Dto
    /// </summary>
   public class UserModelDto : AuditedEntityDto<Guid>
    {

        public string UserName { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string UserHeadPortrait { get; set; }//用户头像
    }
}
