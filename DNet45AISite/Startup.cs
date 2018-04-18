using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DNet45AISite.Startup))]
namespace DNet45AISite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
