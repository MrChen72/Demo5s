using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto
{
    public class tbGoodsDto : AuditedEntityDto<Guid>
    {
        public string Goods_Name { get; set; }  // 商品名

        //图片 
        public string PictId { get; set; }
        public string Picture_Name { get; set; } //图片名称
        //分类
        public string ClassId { get; set; }
        public string Classify_Name { get; set; }
        //品牌
        public string BraId { get; set; }
        public string Brand_Name { get; set; }  //品牌名称
        //规格
        public string SpecId { get; set; }
        public string Spec_Name { get; set; } //规格名称
        //价格
        public double Price { get; set; }

        //库存
        public int StoreNum { get; set; }
    }
}
