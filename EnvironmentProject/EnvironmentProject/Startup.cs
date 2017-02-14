using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnvironmentProject.Startup))]
namespace EnvironmentProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
