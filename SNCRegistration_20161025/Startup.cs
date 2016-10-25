using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SNCRegistration_20161025.Startup))]
namespace SNCRegistration_20161025
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
