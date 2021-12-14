using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationGoodsDto
{
    /// <summary>
    /// 验证商品图片表Dto
    /// </summary>
    public class PictureValidationDto
    {
        [Required]
        public string Picture_Name { get; set; } //图片名称
    }
}
