using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenSampApp.Startup))]
namespace JenSampApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
