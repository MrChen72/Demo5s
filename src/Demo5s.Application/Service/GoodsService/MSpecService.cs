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

    /// <summary>
    /// 规格
    /// </summary>
    public class MSpecService : ApplicationService, IMSpecService
    {

        public readonly IRepository<SpecModel, Guid> specModels;

        public MSpecService(IRepository<SpecModel,Guid> _specModels)
        {
            specModels = _specModels;
        }


        //添加
        public async Task<ResData<SpecModelDto>> Add(SpecModelDto SpecDto)
        {
            var spec = await specModels.InsertAsync(ObjectMapper.Map<SpecModelDto, SpecModel>(SpecDto));
            var specadd = ObjectMapper.Map<SpecModel, SpecModelDto>(spec);

            return new ResData<SpecModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "添加成功",
                Data = specadd
            };
        }

        //显示
        [Microsoft.AspNetCore.Mvc.AcceptVerbs("GET")]
        public async Task<ResData<PagedResultDto<SpecModelDto>>> Show(PagedAndSortedResultRequestDto input, string name)
        {
            var query = specModels;
            var total = await query.CountAsync();

            List<SpecModel> SpecModel = await query
                   .Skip(input.SkipCount)
                   .Take(input.MaxResultCount).ToListAsync();

            List<SpecModelDto> SpecModelDtos =
            ObjectMapper.Map<List<SpecModel>, List<SpecModelDto>>(SpecModel);
            if (name != null)
            {
                SpecModelDtos = SpecModelDtos.Where(u => u.Spec_Name.Contains(name)).ToList();
            }
            //返回结果
            var data = new PagedResultDto<SpecModelDto>(total, SpecModelDtos);

            return new ResData<PagedResultDto<SpecModelDto>>
            {
                State = Enums.BusinessType.succeed,
                Message = "显示成功",
                Data = data
            };
        }
    }
}
