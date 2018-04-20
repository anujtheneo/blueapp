using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blueapp.Startup))]
namespace Blueapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
