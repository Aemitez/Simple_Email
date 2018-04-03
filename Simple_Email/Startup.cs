using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simple_Email.Startup))]
namespace Simple_Email
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
