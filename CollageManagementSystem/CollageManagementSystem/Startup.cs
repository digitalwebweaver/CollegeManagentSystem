using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollageManagementSystem.Startup))]
namespace CollageManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
