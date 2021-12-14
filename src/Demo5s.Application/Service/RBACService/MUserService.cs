using Demo5s.Dto.RBACDto;
using Demo5s.IService.IRBACService;
using Demo5s.RBAC;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo5s.Service.RBACService
{
    /// <summary>
    /// 用户
    /// </summary>
    public class MUserService : ApplicationService, IMUserService
    {

        private readonly IRepository<UserModel, Guid> userModels;

        public MUserService(IRepository<UserModel,Guid> _userModels)
        {
            userModels = _userModels;
        }

        //添加
        public async Task<ResData<UserModelDto>> Add(UserModelDto userModelDto)
        {
            var Users = await userModels.InsertAsync(ObjectMapper.Map<UserModelDto, UserModel>(userModelDto));
            var usersadd = ObjectMapper.Map<UserModel, UserModelDto>(Users);

            return new ResData<UserModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "添加成功",
                Data = usersadd
            };
        }
        //删除
        public async Task<ResData<UserModelDto>> Delete(Guid id)
        {
            await userModels.DeleteAsync(id);
            return new ResData<UserModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "删除成功",
            };
        }
        //反填
        [Microsoft.AspNetCore.Mvc.AcceptVerbs("GET")]
        public async Task<ResData<UserModelDto>> Edit(Guid id)
        {
            var Users = await userModels.GetAsync(id);
            var usersedit = ObjectMapper.Map<UserModel, UserModelDto>(Users);

            return new ResData<UserModelDto>
            {
                State = Enums.BusinessType.succeed,
                Message = "反填成功",
                Data = usersedit
            };

        }
        //显示
        [Microsoft.AspNetCore.Mvc.AcceptVerbs("GET")]
        public async Task<ResData<PagedResultDto<UserModelDto>>> Show(PagedAndSortedResultRequestDto input, string name)
        {
            var query = userModels;
            var total = query.Count();
            List<UserModel> listuserModel = await query
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount).ToListAsync();
            List<UserModelDto> tbUserModels = ObjectMapper.Map<List<UserModel>, List<UserModelDto>>(listuserModel);
            if (name!=null)
            {
                tbUserModels = tbUserModels.Where(x => x.UserName.Contains(name)).ToList();
            }

            //返回结果
            var data = new PagedResultDto<UserModelDto>(total, tbUserModels);
            return new ResData<PagedResultDto<UserModelDto>>
            {
                State = Enums.BusinessType.succeed,
                Message = "反填成功",
                Data = data
            };

        }
        //修改
        public async Task<ResData<UserModelDto>> Update(UserModelDto userModelDto)
        {
            var Info = await userModels.UpdateAsync(ObjectMapper.Map<UserModelDto, UserModel>(userModelDto));
            var infoUpd = ObjectMapper.Map<UserModel, UserModelDto>(Info);
                       
             return new ResData<UserModelDto>
             {
                 State = Enums.BusinessType.succeed,
                 Message = "修改成功",
                 Data = infoUpd
             };

        }
    }
}
