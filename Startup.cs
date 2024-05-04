using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BestBooksReviewMVC.Startup))]
namespace BestBooksReviewMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
