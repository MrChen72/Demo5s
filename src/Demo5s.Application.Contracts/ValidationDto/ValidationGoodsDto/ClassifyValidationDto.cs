using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationGoodsDto
{
    /// <summary>
    /// 验证商品分类Dto
    /// </summary>
    public class ClassifyValidationDto
    {
        [Required]
        public string Classify_Name { get; set; }
    }
}
