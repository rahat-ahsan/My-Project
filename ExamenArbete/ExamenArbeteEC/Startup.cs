using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenArbeteEC.Startup))]
namespace ExamenArbeteEC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
