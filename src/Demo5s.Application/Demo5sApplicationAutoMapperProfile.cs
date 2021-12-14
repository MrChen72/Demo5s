using AutoMapper;
using Demo5s.Dto;
using Demo5s.Goods;

namespace Demo5s
{
    public class Demo5sApplicationAutoMapperProfile : Profile
    {
        public Demo5sApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            #region Goods
            CreateMap<GoodsModel, GoodsModelDto>();
            CreateMap<GoodsModelDto, GoodsModel>();

            CreateMap<BrandModel, BrandModelDto>();
            CreateMap<BrandModelDto, BrandModel>();

            CreateMap<ClassifyModel, ClassifyModelDto>();
            CreateMap<ClassifyModelDto, ClassifyModel>();

            CreateMap<PictureModel, PictureModelDto>();
            CreateMap<PictureModelDto, PictureModel>();

            CreateMap<SpecModel, SpecModelDto>();
            CreateMap<SpecModelDto, SpecModel>();
            #endregion  
        }
    }
}
