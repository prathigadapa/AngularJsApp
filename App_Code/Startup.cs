using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnugularTestApp.Startup))]
namespace AnugularTestApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
