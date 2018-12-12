using Microsoft.Owin;
using Owin;
//using Swashbuckle.Application;
using System.Web.Http;

[assembly: OwinStartupAttribute(typeof(AdventureWorks.Web.Startup))]
namespace AdventureWorks.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //var httpConfiguration = new HttpConfiguration();
            //httpConfiguration.EnableSwagger(c => c.SingleApiVersion("v1", "Jenny API"))
            //  .EnableSwaggerUi();
        }

        
    }
}
