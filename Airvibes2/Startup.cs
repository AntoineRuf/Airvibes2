using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Airvibes2.Startup))]
namespace Airvibes2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
