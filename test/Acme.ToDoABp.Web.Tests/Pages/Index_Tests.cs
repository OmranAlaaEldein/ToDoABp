using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.ToDoABp.Pages
{
    public class Index_Tests : ToDoABpWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
