using Acme.ToDoABp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.ToDoABp.Permissions
{
    public class ToDoABpPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ToDoABpPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(ToDoABpPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ToDoABpResource>(name);
        }
    }
}
