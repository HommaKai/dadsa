using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectWebApplication.Startup))]
namespace ProjectWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
