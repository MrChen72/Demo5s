using Demo5s.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo5s.IService.IGoodsService
{
    /// <summary>
    /// 规格
    /// </summary>
    public interface IMSpecService :IApplicationService
    {

        //添加
        Task<ResData<SpecModelDto>> Add(SpecModelDto SpecDto);

        //显示
        Task<ResData<PagedResultDto<SpecModelDto>>> Show(PagedAndSortedResultRequestDto input,string name);
    }
}
