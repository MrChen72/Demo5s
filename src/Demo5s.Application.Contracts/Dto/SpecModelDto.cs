using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto
{
    /// <summary>
    /// 规格Dto
    /// </summary>
    public class SpecModelDto : AuditedEntityDto<Guid>
    {
        public string Spec_Name { get; set; } //规格名称
    }
}
