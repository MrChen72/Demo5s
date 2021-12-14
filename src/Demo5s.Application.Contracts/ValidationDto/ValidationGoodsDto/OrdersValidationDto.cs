using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo5s.ValidationDto.ValidationGoodsDto
{
    /// <summary>
    /// 验证订单表Dto
    /// </summary>
    public class OrdersValidationDto
    {
        //收件人姓名
        [Required]
        public string Name { get; set; }
        //收件人电话
        [Required]
        public string Phone { get; set; }

        //省
        [Required]
        public string CityProvince { get; set; }
        //市
        [Required]
        public string City { get; set; }
        //区
        [Required]
        public string CityDistrict { get; set; }
        //地址详情
        [Required]
        public string CityDetail { get; set; }

        //是否默认
        [Required]
        public string IsDet { get; set; }

        [Required]
        public Guid GoodsID { get; set; } //商品id
    }
}
