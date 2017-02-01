using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CanadaLab.Startup))]
namespace CanadaLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
