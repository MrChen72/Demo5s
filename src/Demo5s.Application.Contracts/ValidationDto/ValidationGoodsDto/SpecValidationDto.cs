using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationGoodsDto
{
    /// <summary>
    /// 验证商品规格表Dto
    /// </summary>
    public class SpecValidationDto
    {
        [Required]
        public string Spec_Name { get; set; } //规格名称
    }
}
