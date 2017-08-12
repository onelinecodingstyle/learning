using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Readme.Startup))]
namespace Project_Readme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
