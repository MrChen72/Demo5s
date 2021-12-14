using Demo5s.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5s
{
    public class ResData<T>
    {
        /// <summary>
        /// 状态
        /// </summary>
        public BusinessType State { get; set; }

        /// <summary>
        /// 返回成功
        /// </summary>
        public string Message { get; set; }


        public int Jwt { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        public T Data { get; set; }
    }
}
