using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(NurseCallMvc.Web.Startup))]

namespace NurseCallMvc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            this.ConfigureAuth(app);

        }
    }
}
