using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.ToDoABp.Web
{
    [Dependency(ReplaceServices = true)]
    public class ToDoABpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ToDoABp";
    }
}
