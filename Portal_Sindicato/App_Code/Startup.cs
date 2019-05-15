using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portal_Sindicato.Startup))]
namespace Portal_Sindicato
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
