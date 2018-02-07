using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieBox.Startup))]
namespace MovieBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
