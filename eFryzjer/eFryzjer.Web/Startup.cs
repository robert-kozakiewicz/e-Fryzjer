using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eFryzjer.Web.Startup))]
namespace eFryzjer.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
