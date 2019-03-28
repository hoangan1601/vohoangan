using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoangAn1611061946.Startup))]
namespace HoangAn1611061946
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
