using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoWebApp.Startup))]
namespace VideoWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
