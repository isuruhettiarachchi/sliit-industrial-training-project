using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sliit_industrial_training_project.Startup))]
namespace sliit_industrial_training_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
