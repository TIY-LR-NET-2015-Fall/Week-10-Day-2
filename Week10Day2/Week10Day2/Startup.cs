using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week10Day2.Startup))]
namespace Week10Day2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
