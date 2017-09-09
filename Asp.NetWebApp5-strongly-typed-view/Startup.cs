using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp.NetWebApp5_strongly_typed_view.Startup))]
namespace Asp.NetWebApp5_strongly_typed_view
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
