using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_14Agosto.Startup))]
namespace _14Agosto
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
