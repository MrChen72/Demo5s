using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.Goods
{
    /// <summary>
    /// 商品分类表
    /// </summary>
    public class ClassifyModel : BasicAggregateRoot<Guid>
    {
        public string Classify_Name { get; set; }
    }
}
