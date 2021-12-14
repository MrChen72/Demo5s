using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.Goods
{
    /// <summary>
    /// 商品品牌表
    /// </summary>
    public class BrandModel : BasicAggregateRoot<Guid>
    {
        public string Brand_Name { get; set; }  //品牌名称
    }
}

