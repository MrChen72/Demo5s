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
    public class MGoodsService : ApplicationService, IMGoodsService
    {
        private readonly IRepository<GoodsModel, Guid> goodsModels;
        private readonly IRepository<BrandModel, Guid> brandModels;

        private readonly IRepository<ClassifyModel,Guid> classifyModels;
        private readonly IRepository<PictureModel, Guid>  pictureModels;

        private readonly IRepository<SpecModel, Guid>  specModels;


        public MGoodsService(
                IRepository<GoodsModel,Guid> _goodsModels,
                IRepository<BrandModel, Guid> _brandModels,
                IRepository<ClassifyModel, Guid>_classifyModels,
                IRepository<PictureModel, Guid> _pictureModels,
                IRepository<SpecModel, Guid>  _specModels

            )
        {
            goodsModels = _goodsModels;
            brandModels = _brandModels;
            classifyModels = _classifyModels;
            pictureModels = _pictureModels;
            specModels = _specModels;
        }




        ///添加
        public async Task<ResData<GoodsModelDto>> Add(GoodsModelDto goodsDto)
        {
            var Goods = await goodsModels.InsertAsync(ObjectMapper.Map<GoodsModelDto, GoodsModel>(goodsDto));

            var goodsadd = ObjectMapper.Map<GoodsModel, GoodsModelDto>(Goods);

            return new ResData<GoodsModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "添加成功",
                Data = goodsadd
            };
        }
            
           
        //删除
        public async Task<ResData<GoodsModelDto>> Delete(Guid id)
        {
            await goodsModels.DeleteAsync(id);
           
            var aa = new ResData<GoodsModelDto>();
            var stat = aa.State = Enums.BusinessType.succeed;
            if (stat.Equals(1))
            {
                return new ResData<GoodsModelDto> { Message = "删除成功" };
            }
            else
            {
                return new ResData<GoodsModelDto> { Message = "删除失败" };
            }
            //return new ResData<GoodsModelDto>
            //{
            //    State = Enums.BusinessType.succeed,
            //    Message = "删除成功",
            //};
        }

        //反填
        [Microsoft.AspNetCore.Mvc.AcceptVerbs("GET")]        
        public async Task<ResData<GoodsModelDto>> Edit(Guid id)
        {
            var data = await goodsModels.GetAsync(id);
            var goodsedit = ObjectMapper.Map<GoodsModel, GoodsModelDto>(data);
            return new ResData<GoodsModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "反填成功",
                Data = goodsedit
            };
        }
        //显示
        [Microsoft.AspNetCore.Mvc.AcceptVerbs("GET")]
        public async Task<ResData<PagedResultDto<GoodsModelDto>>> Show(PagedAndSortedResultRequestDto input, string name)
        {
            var query = goodsModels;

            var total =  query.Count();
            List<GoodsModel> GoodsShow1= await query
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount).ToListAsync();

            List<GoodsModelDto> tbGoodsDtos = ObjectMapper.Map<List<GoodsModel>, List<GoodsModelDto>>(GoodsShow1);

            if (name!=null)
            {
                tbGoodsDtos = tbGoodsDtos.Where(u => u.Goods_Name.Contains(name)).ToList();
            }
            //返回结果
            var data = new PagedResultDto<GoodsModelDto>(total, tbGoodsDtos);

            return new ResData<PagedResultDto<GoodsModelDto>>
            {
                State = Enums.BusinessType.succeed,
                Message = "显示成功",
                Data = data
            };
        }

        //修改
        public async Task<ResData<GoodsModelDto>> Updete(GoodsModelDto goodsDto)
        {
            var Info = await goodsModels.UpdateAsync(ObjectMapper.Map<GoodsModelDto, GoodsModel>(goodsDto));

            var infoUpt = ObjectMapper.Map<GoodsModel, GoodsModelDto>(Info);

            return new ResData<GoodsModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "修改成功",
                Data = infoUpt
            };
        }

        //联查
        [Microsoft.AspNetCore.Mvc.AcceptVerbs("GET")]
        public async Task<ResData<PagedResultDto<tbGoodsDto>>> GetGoodsModel(int pageIndex=1,int pageSize=2)
        {
            var query = await (from m in goodsModels
                               join b in brandModels
                               on m.BraId equals b.Id.ToString()
                               join c in classifyModels
                               on m.PictId equals c.Id.ToString()
                               join p in pictureModels
                               on m.PictId equals p.Id.ToString()
                               join s in specModels
                               on m.SpecId equals s.Id.ToString()
                               select new tbGoodsDto
                               {
                                   Goods_Name = m.Goods_Name,
                                   PictId = m.PictId,
                                   Picture_Name = p.Picture_Name,
                                   ClassId = m.ClassId,
                                   Classify_Name = c.Classify_Name,
                                   BraId = m.BraId,
                                   Brand_Name = b.Brand_Name,
                                   SpecId = m.SpecId,
                                   Spec_Name = s.Spec_Name,
                                   Price = m.Price,
                                   StoreNum = m.StoreNum
                               }).ToListAsync();

            int total = query.Count();
            var infos = query.OrderBy(u => u.Id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            var data = new PagedResultDto<tbGoodsDto>(total, infos);

            return new ResData<PagedResultDto<tbGoodsDto>>
            {
                State = Enums.BusinessType.succeed,
                Message = "显示成功",
                Data = data
            };
        }
    }
}
