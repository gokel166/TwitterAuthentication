using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterService.Startup))]
namespace TwitterService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
