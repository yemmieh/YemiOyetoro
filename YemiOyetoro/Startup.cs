using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YemiOyetoro.Startup))]
namespace YemiOyetoro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
