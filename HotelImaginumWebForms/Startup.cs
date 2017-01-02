using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelImaginumWebForms.Startup))]
namespace HotelImaginumWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
