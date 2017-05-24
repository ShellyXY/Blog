using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChineseBudFood.Startup))]
namespace ChineseBudFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
