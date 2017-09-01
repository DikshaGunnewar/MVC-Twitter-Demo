using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(twitterdemo.Startup))]
namespace twitterdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
