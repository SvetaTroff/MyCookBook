using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CookieRecept.Startup))]
namespace CookieRecept
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
