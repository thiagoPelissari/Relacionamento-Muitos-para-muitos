using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Relacionamento.Startup))]
namespace Relacionamento
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
