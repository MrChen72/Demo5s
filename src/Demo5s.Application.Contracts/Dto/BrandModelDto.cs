using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto
{
    /// <summary>
    /// 品牌Dto
    /// </summary>
    public class BrandModelDto : AuditedEntityDto<Guid>
    {
        public string Brand_Name { get; set; }  //品牌名称
    }
}
