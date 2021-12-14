using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationGoodsDto
{
    /// <summary>
    /// 验证品牌Dto
    /// </summary>
    public class BrandValidationDto
    {
        [Required]
        public string Brand_Name { get; set; }  //品牌名称
    }
}
