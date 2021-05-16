using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment1_CCTheory.Startup))]
namespace Assignment1_CCTheory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
