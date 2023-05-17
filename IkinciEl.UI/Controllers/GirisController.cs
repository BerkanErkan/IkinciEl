using IkinciEl.UI.Models.DAL;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace IkinciEl.UI.Controllers
{
    [AllowAnonymous]
    public class GirisController : Controller
    {
        // GET: Giris
        public ActionResult Index()
        {
            KullaniciVM vm = new KullaniciVM();

            if (User.Identity.IsAuthenticated)
            {


                return RedirectToAction("Index", "Home");

            }
            //if (ModelState.IsValid)
            //{

            //}

            //if (Request.Cookies["bilgiler"] != null)
            //{

            //    var httpCookie = Request.Cookies["bilgiler"];
            //    vm.Mail = httpCookie.Values["username"];
            //}


            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(KullaniciVM vm)
        {

            KullaniciVM vm2 = new GirisDAL().KullaniciKontrolu(vm);

            

            if (vm2!=null)
            {
                //HttpCookie cookie = new HttpCookie("bilgiler");
                //cookie.Expires = DateTime.Now.AddDays(1);
                //cookie.Values.Add("mail", vm.Mail);
                //HttpContext.Response.Cookies.Add(cookie);

                FormsAuthentication.SetAuthCookie(vm.Mail, false);

                Session.Add("kullanici", vm2);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index");
            }


            
            
        }


        public ActionResult LogOut()
        {

            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Giris");


        }
    }
}