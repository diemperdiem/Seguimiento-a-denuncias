using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Robos.Startup))]
namespace Robos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
