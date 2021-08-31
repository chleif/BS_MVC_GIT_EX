using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BS_MVC_GIT_EX.Startup))]
namespace BS_MVC_GIT_EX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
