using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnionArchERP.Startup))]
namespace OnionArchERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
