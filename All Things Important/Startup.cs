using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(All_Things_Important.Startup))]
namespace All_Things_Important
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
