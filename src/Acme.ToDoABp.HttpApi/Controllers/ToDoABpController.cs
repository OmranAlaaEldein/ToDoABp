using Acme.ToDoABp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.ToDoABp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ToDoABpController : AbpController
    {
        protected ToDoABpController()
        {
            LocalizationResource = typeof(ToDoABpResource);
        }
    }
}