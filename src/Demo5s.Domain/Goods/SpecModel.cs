using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.Goods
{
    /// <summary>
    /// 商品规格表
    /// </summary>
    public class SpecModel : BasicAggregateRoot<Guid>
    {
        public string Spec_Name { get; set; } //规格名称
    }
}
