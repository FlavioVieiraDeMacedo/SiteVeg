using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using VegClasic.Models;

[assembly: OwinStartupAttribute(typeof(VegClasic.Startup))]
namespace VegClasic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            createDefaultUser();
            ConfigureAuth(app);
        }

        public void createDefaultUser()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var user = new ApplicationUser();
            user.UserName = "adm@adm.com";
            user.Email = "adm@adm.com";

            string userPWD = "Flavio@123";
            var chkUser = UserManager.Create(user, userPWD);

        }
    }
}
