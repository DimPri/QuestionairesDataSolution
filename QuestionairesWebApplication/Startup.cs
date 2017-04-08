using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuestionairesWebApplication.Startup))]
namespace QuestionairesWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
