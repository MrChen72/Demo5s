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
    /// 分类
    /// </summary>
    public interface IMClassifyService :IApplicationService
    {
        //显示
        Task<ResData<PagedResultDto<ClassifyModelDto>>> Show(PagedAndSortedResultRequestDto input, string name);
        //添加
        Task<ResData<ClassifyModelDto>> Add(ClassifyModelDto ClassifyDto);
    }
}
