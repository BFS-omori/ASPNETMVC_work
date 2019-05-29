using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETMVC_work.Startup))]
namespace ASPNETMVC_work
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
