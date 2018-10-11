using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restart.Startup))]
namespace Restart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
