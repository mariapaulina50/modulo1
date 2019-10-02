using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodHealthModulo1Final.Startup))]
namespace FoodHealthModulo1Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
