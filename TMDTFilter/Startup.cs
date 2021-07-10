using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDTFilter.Startup))]
namespace TMDTFilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
