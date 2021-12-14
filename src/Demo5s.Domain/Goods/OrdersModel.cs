using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.Goods
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class OrdersModel : BasicAggregateRoot<Guid>
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
