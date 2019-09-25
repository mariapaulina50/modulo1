using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodHealthModulo1.Startup))]
namespace FoodHealthModulo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
