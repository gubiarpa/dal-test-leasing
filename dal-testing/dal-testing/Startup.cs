using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dal_testing.Startup))]
namespace dal_testing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
