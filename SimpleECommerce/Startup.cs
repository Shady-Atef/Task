using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleECommerce.Startup))]
namespace SimpleECommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
