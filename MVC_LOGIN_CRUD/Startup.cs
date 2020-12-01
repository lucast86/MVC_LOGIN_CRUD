using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_LOGIN_CRUD.Startup))]
namespace MVC_LOGIN_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
