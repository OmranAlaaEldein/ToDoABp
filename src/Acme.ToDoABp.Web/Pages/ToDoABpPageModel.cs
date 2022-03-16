using Acme.ToDoABp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.ToDoABp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ToDoABpPageModel : AbpPageModel
    {
        protected ToDoABpPageModel()
        {
            LocalizationResourceType = typeof(ToDoABpResource);
        }
    }
}