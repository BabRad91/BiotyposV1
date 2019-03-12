using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BiotyposV1.Startup))]
namespace BiotyposV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
