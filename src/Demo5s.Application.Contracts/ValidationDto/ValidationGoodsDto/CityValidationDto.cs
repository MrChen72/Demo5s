using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationGoodsDto
{
    /// <summary>
    /// 验证城市表Dto
    /// </summary>
    public class CityValidationDto
    {
        [Required]
        public Guid FatherId { get; set; }

        [Required]
        public string CityName { get; set; }
    }
}
