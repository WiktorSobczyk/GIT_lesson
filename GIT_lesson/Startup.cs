using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIT_lesson.Startup))]
namespace GIT_lesson
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
