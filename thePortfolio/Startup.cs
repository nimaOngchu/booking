using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(thePortfolio.Startup))]
namespace thePortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
