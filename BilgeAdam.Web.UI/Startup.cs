using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BilgeAdam.Web.UI.Startup))]
namespace BilgeAdam.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
