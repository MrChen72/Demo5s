using Demo5s.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;


namespace Demo5s.IService.IGoodsService
{
    public interface IMBrandService :IApplicationService
    {   
        //显示
        Task<ResData<PagedResultDto<BrandModelDto>>> Show(PagedAndSortedResultRequestDto input, string name);

        //添加
        Task<ResData<BrandModelDto>> Add(BrandModelDto brandDto);
    }
}
