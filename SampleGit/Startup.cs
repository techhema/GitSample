using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleGit.Startup))]
namespace SampleGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
