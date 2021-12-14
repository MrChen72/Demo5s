using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto
{
    /// <summary>
    /// 图片Dto
    /// </summary>
    public class PictureModelDto : AuditedEntityDto<Guid>
    {
        public string Picture_Name { get; set; } //图片名称
    }
}
