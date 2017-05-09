using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstCrudApp.Startup))]
namespace MyFirstCrudApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
