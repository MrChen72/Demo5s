using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationGoodsDto
{
    /// <summary>
    /// 验证商品表Dto
    /// </summary>
    public class GoodsValidationDto
    {
        [Required]
        public string Goods_Name { get; set; }  // 商品名

        //图片 
        [Required]
        public string PictId { get; set; }

        //分类
        [Required]
        public string ClassId { get; set; }

        //品牌
        [Required]
        public string BraId { get; set; }

        //规格
        [Required]
        public string SpecId { get; set; }

        //价格
        [Required]
        public double Price { get; set; }

        //库存
        [Required]
        public int StoreNum { get; set; }
    }
}
