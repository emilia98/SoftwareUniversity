using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BombTheFruits___WebGame.Startup))]
namespace BombTheFruits___WebGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
