using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularPlunin.Startup))]
namespace AngularPlunin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
