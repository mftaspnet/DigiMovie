using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S7.Startup))]
namespace S7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
