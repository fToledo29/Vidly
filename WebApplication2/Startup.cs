using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyII.Startup))]
namespace VidlyII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
