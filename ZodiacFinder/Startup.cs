using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZodiacFinder.Startup))]
namespace ZodiacFinder
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
