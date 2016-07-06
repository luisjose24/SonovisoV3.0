using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sono_Viso.Web.Startup))]
namespace Sono_Viso.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
