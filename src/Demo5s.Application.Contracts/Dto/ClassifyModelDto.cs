using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto
{
    /// <summary>
    /// 商品分类Dto
    /// </summary>
    public class ClassifyModelDto :AuditedEntityDto<Guid>
    {
        public string Classify_Name { get; set; }
    }
}
