using IkinciEl.CF.Models.Entities;
using IkinciEl.UI.Models.DAL;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace IkinciEl.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            
            if (TempData["kullaniciList"]!=null)
            {
                var kullniciList = TempData["kullaniciList"] as List<KullaniciVM>;
                ViewBag.KullaniciList = kullniciList;
            }
            else 
            {
                List<KullaniciVM> kullniciList = new KullaniciDAL().KullanicilarinHepsiniDoldur();
                ViewBag.KullaniciList = kullniciList;

            }    

            
            return View();
        }
        [HttpPost]
        public ActionResult IndexKullaniciOnay()
        {
            if (ModelState.IsValid)
            {
                

                bool onayDurumu = Convert.ToBoolean(Request["Onay"]);


                List<KullaniciVM> kullniciList = new KullaniciDAL().KullaniciDoldur(onayDurumu);

                TempData["kullaniciList"] = kullniciList;

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.loginError = "hata";
                return View("Index");
            }
            

        }
        [HttpPost]
        public ActionResult IndexKullaniciRol()
        {


            int rolID = Convert.ToInt32(Request["Rol"]);



            List<KullaniciVM> kullniciList = new KullaniciDAL().KullaniciRoleGoreDoldur(rolID);

            TempData["kullaniciList"] = kullniciList;

            return RedirectToAction("Index");


        }

        [HttpPost]
        public ActionResult KullaniciSil(int kullaniciID)
        {
            bool a = new KullaniciDAL().KullaniciSil(kullaniciID);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult IndexKullaniciEkle()
        {



            return RedirectToAction("KullaniciEkle");

        }
        [HttpPost]
        public ActionResult IndexKurumsalKullaniciEkle()
        {

            return RedirectToAction("KurumsalKullaniciEkle");
        }

        [HttpGet]
        public ActionResult KullaniciEkle()
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            var kullaniciSon = TempData["araKullanici"] as KurumsalKullaniciVM;


            List<RolVM> rollist = new RolDAL().RolDoldur();
            ViewBag.rollist = rollist;
            List<PaketVM> paketlist = new PaketDAL().PaketDoldur();
            ViewBag.paketlist = paketlist;


            return View(kullaniciSon);
        }
        [HttpPost]
        public ActionResult KullaniciEkle(KurumsalKullaniciVM vm, string name)
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;


            if (name == "Kaydet")
            {

                var a = new KullaniciDAL().KullaniciEkle(vm);
            }
            else if (name == "Guncelle")
            {
                var a = new KullaniciDAL().KullaniciGuncelle(vm);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult KurumsalKullaniciEkle()
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            List<FirmaTuruVM> firmaTuruList = new FirmaTuruDAL().FirmaTuruDoldur();
            ViewBag.firmaTuruList = firmaTuruList;

            List<RolVM> rollist = new RolDAL().RolDoldur();
            ViewBag.rollist = rollist;
            List<PaketVM> paketlist = new PaketDAL().PaketDoldur();
            ViewBag.paketlist = paketlist;

            var kullaniciSon = TempData["araKullanici"] as KurumsalKullaniciVM;



            return View(kullaniciSon);
        }
        [HttpPost]
        public ActionResult KurumsalKullaniciEkle(KurumsalKullaniciVM vm, string name)
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            if (name == "Kaydet")
            {

                var a = new KullaniciDAL().KurumsalKullaniciEkle(vm);
            }
            else if (name == "Guncelle")
            {
                var a = new KullaniciDAL().KurumsalKullaniciGuncelle(vm);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult IndexKullaniciDuzenle(int kullaniciID)
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            KurumsalKullaniciVM araKullanici = new KullaniciDAL().KullaniciBilgisi(kullaniciID);
            TempData["araKullanici"] = araKullanici;

            if (araKullanici.RolID == 1 || araKullanici.RolID == 3)
            {
                return RedirectToAction("KullaniciEkle");
            }
            else
            {
                return RedirectToAction("KurumsalKullaniciEkle");

            }

            
        }



    }
}