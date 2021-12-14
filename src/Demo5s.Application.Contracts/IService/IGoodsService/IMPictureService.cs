using Demo5s.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo5s.IService.IGoodsService
{
    /// <summary>
    /// 图片
    /// </summary>
    public interface IMPictureService :IApplicationService
    {

        //添加
        Task<ResData<PictureModelDto>> ImgAdd(PictureModelDto PictureDto);

        public Task<List<string>> UploadAsync(IFormFileCollection files, string strDirName);

    }
}
