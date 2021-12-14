using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto
{
    /// <summary>
    /// 城市Dto
    /// </summary>
    public class CityModelDto : AuditedEntityDto<Guid>
    {
        public Guid FatherId { get; set; }
        public string CityName { get; set; }
    }
}
