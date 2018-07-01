using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechnoPagan.Startup))]
namespace TechnoPagan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
