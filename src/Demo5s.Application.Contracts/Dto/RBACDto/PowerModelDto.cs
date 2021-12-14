using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto.RBACDto
{
    /// <summary>
    /// 权限表Dto
    /// </summary>
    public class PowerModelDto : AuditedEntityDto<Guid>
    {
        public string PowerName { get; set; }  //名称
        public string PowerDetail { get; set; } //详情
    }
}
