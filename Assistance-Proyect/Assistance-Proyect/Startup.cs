using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assistance_Proyect.Startup))]
namespace Assistance_Proyect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
