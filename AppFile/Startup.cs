using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppFile.Startup))]
namespace AppFile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
