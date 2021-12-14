using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.Goods
{
    /// <summary>
    /// 城市表
    /// </summary>
    public class CityModel : BasicAggregateRoot<Guid> 
    {
        public Guid FatherId { get; set; }
        public string CityName { get; set; }
    }
}
