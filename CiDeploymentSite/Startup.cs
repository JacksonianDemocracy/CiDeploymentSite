using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CiDeploymentSite.Startup))]
namespace CiDeploymentSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
