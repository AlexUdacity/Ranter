using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ranter.Startup))]
namespace Ranter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
