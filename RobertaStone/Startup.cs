using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RobertaStone.Startup))]
namespace RobertaStone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
