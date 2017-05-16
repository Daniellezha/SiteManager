using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteManager.Startup))]
namespace SiteManager
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
