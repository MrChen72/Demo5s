using Demo5s.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Demo5s.Permissions
{
    public class Demo5sPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Demo5sPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(Demo5sPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Demo5sResource>(name);
        }
    }
}
