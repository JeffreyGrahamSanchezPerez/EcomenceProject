using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcomenceWeb.Startup))]
namespace EcomenceWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
