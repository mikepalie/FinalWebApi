using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalWebApi.Startup))]
namespace FinalWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
