using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using ClinicForAnimal1._2.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.Google;

[assembly: OwinStartup(typeof(ClinicForAnimal1._2.Models.Startup))]

namespace ClinicForAnimal1._2.Models
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // настраиваем контекст и менеджер
            app.CreatePerOwinContext(ApplicationContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationRoleManager>(ApplicationRoleManager.Create);



            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
               
            });
         
            //app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            //{
            //    ClientId = "171617413856-emgqr608r66asvqmn45okjs3l7lmggpq.apps.googleusercontent.com",
            //    ClientSecret = "LluRURKloF8HLmOJV7gWDZs2"
            //});
        }
    }
}