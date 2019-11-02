using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smartmom.Startup))]
namespace Smartmom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
