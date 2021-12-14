using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.Reptile
{
    /// <summary>
    /// 爬虫表
    /// </summary>
    public class ReptileModel : BasicAggregateRoot<Guid>
    {
        public string ReptileName { get; set; }
        public string ReptileNode { get; set; }
    }
}
