using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieBox.Startup))]
<<<<<<< HEAD
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
namespace MovieBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
