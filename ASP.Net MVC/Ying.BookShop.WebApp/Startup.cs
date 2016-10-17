using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ying.BookShop.WebApp.Startup))]
namespace Ying.BookShop.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
