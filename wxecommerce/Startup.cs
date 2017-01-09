using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wxecommerce.Startup))]
namespace wxecommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
