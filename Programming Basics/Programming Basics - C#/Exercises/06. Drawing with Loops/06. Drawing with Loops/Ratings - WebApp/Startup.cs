using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ratings___WebApp.Startup))]
namespace Ratings___WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
