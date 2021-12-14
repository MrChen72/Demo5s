using Demo5s.Dto.RBACDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo5s.IService.IRBACService
{
    public interface IMUserService :IApplicationService
    {
        //显示
        Task<ResData<PagedResultDto<UserModelDto>>> Show(PagedAndSortedResultRequestDto input, string name);
        Task<ResData<UserModelDto>> Add(UserModelDto userModelDto);//添加
        Task<ResData<UserModelDto>> Delete(Guid id);//删除
        Task<ResData<UserModelDto>> Update(UserModelDto userModelDto);
        Task<ResData<UserModelDto>> Edit(Guid id);//反填
    
    }
}
