using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcGit.Startup))]
namespace MvcGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
