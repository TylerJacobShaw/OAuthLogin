using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RemusWeb.Startup))]
namespace RemusWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
