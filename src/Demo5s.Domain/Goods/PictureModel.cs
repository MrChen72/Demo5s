using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.Goods
{
    /// <summary>
    /// 商品图片表
    /// </summary>
    public class PictureModel : BasicAggregateRoot<Guid>
    {
        public string Picture_Name { get; set; } //图片名称
    }
}
