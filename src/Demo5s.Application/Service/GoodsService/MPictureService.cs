using Demo5s.Dto;
using Demo5s.Goods;
using Demo5s.IService.IGoodsService;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo5s.Service.GoodsService
{
    /// <summary>
    /// 添加图片
    /// </summary>
    public class MPictureService : ApplicationService, IMPictureService
    {

        private readonly IRepository<PictureModel, Guid> pictureModels;

        Microsoft.AspNetCore.Hosting.IWebHostEnvironment _host;
        public MPictureService(IRepository<PictureModel, Guid> _pictureModels,
            Microsoft.AspNetCore.Hosting.IWebHostEnvironment host)
        {
            pictureModels = _pictureModels;
            _host = host;
        }


        /// <summary>
        /// 添加数据库图片字段名称
        /// </summary>
        /// <param name="PictureDto"></param>
        /// <returns></returns>
        public async Task<ResData<PictureModelDto>> ImgAdd(PictureModelDto PictureDto)
        {
            var picture = await pictureModels.InsertAsync(ObjectMapper.Map<PictureModelDto, PictureModel>(PictureDto));
            var pictureadd = ObjectMapper.Map<PictureModel, PictureModelDto>(picture);

            return new ResData<PictureModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "添加成功",
                Data = pictureadd
            };
        }

         
        //添加文件存放位置
        //添加文件路径
        public async Task<List<string>> UploadAsync(IFormFileCollection files, string strDirName= "Imgs")
        {
            List<string> path = new List<string>();
            foreach(var item in files)
            {
                if(item.Length>0)
                {
                    var www = _host.WebRootPath;
                    var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(item.FileName);

                    var dirPath = Path.Combine(www, strDirName);
                    if (!Directory.Exists(dirPath))
                    {
                        Directory.CreateDirectory(dirPath);
                    }

                    var filePath = Path.Combine(dirPath, fileName);//文件的保存路径

                    using (var stream=new FileStream(filePath,FileMode.Create,FileAccess.ReadWrite))
                    {
                        await item.CopyToAsync(stream); //保存文件

                        stream.Dispose();

                        path.Add($"/{strDirName}/{fileName}");
                    }
                }
            }

            return path;
        }
    }
}
