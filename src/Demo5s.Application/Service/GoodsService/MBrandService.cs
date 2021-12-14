using Demo5s.Dto;
using Demo5s.Goods;
using Demo5s.IService.IGoodsService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo5s.Service.GoodsService
{
    public class MBrandService : ApplicationService, IMBrandService
    {

        private readonly IRepository<BrandModel, Guid> brandModels;

        public MBrandService(IRepository<BrandModel, Guid> _brandModels)
        {
            brandModels = _brandModels;
        }

        //品牌
        public async Task<ResData<BrandModelDto>> Add(BrandModelDto brandDto)
        {
            var brand = await brandModels.InsertAsync(ObjectMapper.Map<BrandModelDto, BrandModel>(brandDto));
            var brandadd = ObjectMapper.Map<BrandModel, BrandModelDto>(brand);

            return new ResData<BrandModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "添加成功",
                Data = brandadd
            };
        }

        [Microsoft.AspNetCore.Mvc.AcceptVerbs("GET")]
        public async Task<ResData<PagedResultDto<BrandModelDto>>> Show(PagedAndSortedResultRequestDto input, string name)
        {
            var query = brandModels;
            var total = await query.CountAsync();

            List<BrandModel> GoodsBrand = await query
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount).ToListAsync();

            List<BrandModelDto> GoodsBrandDtos =
            ObjectMapper.Map<List<BrandModel>, List<BrandModelDto>>(GoodsBrand);

            if (name!=null)
            {
                GoodsBrandDtos = GoodsBrandDtos.Where(u => u.Brand_Name.Contains(name)).ToList();

            }

            //返回结果
            var data = new PagedResultDto<BrandModelDto>(total, GoodsBrandDtos);

            return new ResData<PagedResultDto<BrandModelDto>>
            {
                State = Enums.BusinessType.succeed,
                Message = "显示成功",
                Data = data
            };
        }
    }
}
