using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChildProgramming.Startup))]
namespace ChildProgramming
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
