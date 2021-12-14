using Demo5s.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo5s.IService.IGoodsService
{
    public interface IMGoodsService : IApplicationService
    {
        ///显示联查 
        Task<ResData<PagedResultDto<GoodsModelDto>>> Show(PagedAndSortedResultRequestDto input, string name);
      
        Task<ResData<GoodsModelDto>> Add(GoodsModelDto goodsDto);  //添加
        
        Task<ResData<GoodsModelDto>> Delete(Guid id);//删除

        Task<ResData<GoodsModelDto>> Updete(GoodsModelDto goodsDto);//修改

        Task<ResData<GoodsModelDto>> Edit(Guid id); //反填

        
    }
}
