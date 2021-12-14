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
    /// 分类
    /// </summary>
    public class MClassifyService : ApplicationService, IMClassifyService
    {

        private readonly IRepository<ClassifyModel, Guid> classifyModels;

        public MClassifyService(IRepository<ClassifyModel,Guid> _classifyModels)
        {
            classifyModels = _classifyModels;
        }

        
        public async Task<ResData<ClassifyModelDto>> Add(ClassifyModelDto ClassifyDto)
        {
            var classify = await classifyModels.InsertAsync(ObjectMapper.Map<ClassifyModelDto, ClassifyModel>(ClassifyDto));
            var classifyadd = ObjectMapper.Map<ClassifyModel, ClassifyModelDto>(classify);
            return new ResData<ClassifyModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "添加成功",
                Data = classifyadd
            };
        }

        [Microsoft.AspNetCore.Mvc.AcceptVerbs("GET")]
        public async Task<ResData<PagedResultDto<ClassifyModelDto>>> Show(PagedAndSortedResultRequestDto input, string name)
        {

            var query = classifyModels;
            var total = await query.CountAsync();

            List<ClassifyModel> ClassifyModels = await query
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount).ToListAsync();

            List<ClassifyModelDto> ClassifyModelDtos =
                ObjectMapper.Map<List<ClassifyModel>, List<ClassifyModelDto>>(ClassifyModels);
            if (name!=null)
            {
                ClassifyModelDtos = ClassifyModelDtos.Where(u => u.Classify_Name.Contains(name)).ToList();
            }

            var data = new PagedResultDto<ClassifyModelDto>(total, ClassifyModelDtos);
            return new ResData<PagedResultDto<ClassifyModelDto>>
            {
                State = Enums.BusinessType.succeed,
                Message="显示成功",
                Data=data
            };
        }
    }
}
