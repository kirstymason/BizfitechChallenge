using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BizfitechChallenge.Startup))]
namespace BizfitechChallenge
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
