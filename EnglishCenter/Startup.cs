using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnglishCenter.Startup))]
namespace EnglishCenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
