using IkinciEl.UI.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace IkinciEl.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalFilters.Filters.Add(new AuthorizeAttribute());


            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }


        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            if (FormsAuthentication.CookiesSupported)
            {
                if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
                {
                    try
                    {

                        

                        string mail = HttpContext.Current.User.Identity.Name;

                        string rolAdi = new GirisDAL().KullaniciRol(mail);


                        HttpContext.Current.User = new GenericPrincipal(
    new System.Security.Principal.GenericIdentity(mail, "Forms"),
    new[] { rolAdi }
);

                    }
                    catch (Exception ex)
                    {
                        throw new HttpException("Hata!", ex);
                    }
                }
            }
        }
    }
}
