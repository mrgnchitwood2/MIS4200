using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectSolutionMISTeam17.Startup))]
namespace ProjectSolutionMISTeam17
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
