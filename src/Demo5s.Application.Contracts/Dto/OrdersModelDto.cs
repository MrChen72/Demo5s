using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo5s.Dto
{
    /// <summary>
    /// 订单Dto
    /// </summary>
    public class OrdersModelDto : AuditedEntityDto<Guid>
    {
        //收件人姓名
        public string Name { get; set; }
        //收件人电话
        public string Phone { get; set; }

        //省
        public string CityProvince { get; set; }
        //市
        public string City { get; set; }
        //区
        public string CityDistrict { get; set; }
        //地址详情
        public string CityDetail { get; set; }

        //是否默认
        public string IsDet { get; set; }

        public Guid GoodsID { get; set; } //商品id
    }
}
