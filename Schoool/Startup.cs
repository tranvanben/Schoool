using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Schoool.Startup))]
namespace Schoool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
