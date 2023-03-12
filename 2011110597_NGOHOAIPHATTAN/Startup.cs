using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011110597_NGOHOAIPHATTAN.Startup))]
namespace _2011110597_NGOHOAIPHATTAN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
