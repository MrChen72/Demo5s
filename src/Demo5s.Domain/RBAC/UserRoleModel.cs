﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo5s.RBAC
{
    /// <summary>
    /// 用户角色表
    /// </summary>
    public class UserRoleModel: BasicAggregateRoot<Guid>
    {
        public string UserId { get; set; }//用户外键
        public string RoleId { get; set; }//角色外键
    }
}
