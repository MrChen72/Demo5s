using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.Goods
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class GoodsModel :BasicAggregateRoot<Guid>
    {
        public string Goods_Name { get; set; }  // 商品名

        //图片 
        public string PictId { get; set; }

        //分类
        public string ClassId { get; set; }

        //品牌
        public string BraId { get; set; }

        //规格
        public string SpecId { get; set; }

        //价格
        public double Price { get; set; }

        //库存
        public int StoreNum { get; set; }
    }
}
