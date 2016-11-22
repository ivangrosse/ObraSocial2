using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ObraSocialWeb_2.Startup))]
namespace ObraSocialWeb_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
