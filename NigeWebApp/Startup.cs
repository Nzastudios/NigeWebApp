using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NigeWebApp.Startup))]
namespace NigeWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
