using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LessSample.Startup))]
namespace LessSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
