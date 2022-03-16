using System;
using System.Collections.Generic;
using System.Text;
using Acme.ToDoABp.Localization;
using Volo.Abp.Application.Services;

namespace Acme.ToDoABp
{
    /* Inherit your application services from this class.
     */
    public abstract class ToDoABpAppService : ApplicationService
    {
        protected ToDoABpAppService()
        {
            LocalizationResource = typeof(ToDoABpResource);
        }
    }
}
