using IkinciEl.CF.Models.Entities;
using IkinciEl.UI.Models.DAL;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace IkinciEl.UI.Controllers
{
    
    public class AracListController : Controller
    {
        // GET: AracList
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;


            if (TempData["aracList"] != null)
            {
                var aracList = TempData["aracList"] as List<AracVM>;
                ViewBag.Araclist = aracList;
            }
            else
            {
                List<AracVM> araclist = new AracDAL().AraclarinepsiniDoldur();
                ViewBag.Araclist = araclist;

            }


            

            List<ModelVM> modelList = new ModelDAL().ModelDoldur();
            ViewBag.Modellist = modelList;

            List<MarkaVM> markalist = new MarkaDAL().MarkaDoldur();
            ViewBag.Markalist = markalist;


            return View();
        }
        [HttpPost]
        public ActionResult Index(AracVM vm)
        {
            int markaID = Convert.ToInt32(Request["MarkaID"]);
            int modelID = Convert.ToInt32(Request["ModelID"]);


            List<AracVM> araclist = new AracDAL().AraclariDoldur(markaID, modelID);
            TempData["aracList"] = araclist;



            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult IndexAracOnay()
        {
            if (ModelState.IsValid)
            {
                KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
                ViewBag.kul = kullanici;

                bool onayDurumu = Convert.ToBoolean(Request["Onay"]);


                List<AracVM> aracList = new AracDAL().AracDoldur(onayDurumu);
                TempData["aracList"] = aracList;

                return RedirectToAction("Index");


            }
            else
            {
                ViewBag.loginError = "hata";
                return View("Index");
            }


        }


        [HttpPost]
        public ActionResult IndexAracDetay(int aracID)
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;


            AracDBVM arac = new AracDAL().AraciDoldur(aracID);
            TempData["araArac"] = arac;
            Session.Add("kaydet", 2);

            return RedirectToAction("AracEkle");
        }

        

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult AracDetayTramer()
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            var araArac = TempData["araArac"] as AracDBVM;

            
            var tramerDurumBilgisi = new TramerDAL().TramerBilgisiDurumDoldur();

            ViewBag.TramerDurumlist= tramerDurumBilgisi;

            var parca = new ParcaDAL().ParcaDoldur();

            ViewBag.Parca = parca;


            return View(araArac);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult AracDetayIlan()
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            var araArac = TempData["araArac"] as AracDBVM;

            var parca = new ParcaDAL().ParcaDoldur();

            ViewBag.Parca = parca;


            return View(araArac);
        }
        [HttpPost]
        public ActionResult AracDetayIlan(AracDBVM vM)
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            TempData["araArac"] = vM;
            

            return RedirectToAction("AracEkle");
        }
        [HttpPost]
        public ActionResult IndexAracEkle()
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            
            Session.Add("kaydet", 1);

            return RedirectToAction("AracEkle");
        }
        
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult AracEkle()
        {
            var araArac = TempData["araArac"] as AracDBVM;

            var a = Session["kaydet"];

            ViewBag.Kaydet = a;
           


            

            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            List<ModelVM> modelList = new ModelDAL().ModelDoldur();
            ViewBag.Modellist = modelList;

            List<MarkaVM> markalist = new MarkaDAL().MarkaDoldur();
            ViewBag.Markalist = markalist;

            List<SirketVM> sirketlist = new SirketDAL().SirketDoldur();
            ViewBag.Sirketlist = sirketlist;

            List<StatuTipiVM> statuTipilist = new StatuTipiDAL().StatuTipiDoldur();
            ViewBag.StatuTipilist = statuTipilist;

            List<GovdeTipiVM> govdeTipilist = new GovdeTipiDAL().GovdeTipiDoldur();
            ViewBag.GovdeTipilist = govdeTipilist;

            List<YakitTipiVM> yakitTipilist = new YakitTipiDAL().YakitTipiDoldur();
            ViewBag.YakitTipilist = yakitTipilist;

            List<VitesTipiVM> vitesTipilist = new VitesTipiDAL().VitesTipiDoldur();
            ViewBag.VitesTipilist = vitesTipilist;

            List<RenkVM> renklist = new RenkDAL().RenkDoldur();
            ViewBag.Renklist = renklist;

            List<DonanimVM> donanimlist = new DonanimDAL().DonanimDoldur();
            ViewBag.Donanimlist = donanimlist;

            var parca = new ParcaDAL().ParcaDoldur();

            ViewBag.Parca = parca;
            



            if (araArac == null)
            {
                AracDBVM arac = new AracDBVM();

                List<TramerVM> tramerVMs = new List<TramerVM>();
                foreach (var parca2 in ViewBag.Parca)
                {
                    tramerVMs.Add(new TramerVM { ParcaID = parca2.ParcaID });
                }

                arac.tramerVMs= tramerVMs;

                return View(arac);
            }
            if (araArac.tramerVMs.Count <= 0)
            {
                List<TramerVM> tramerVMs = new List<TramerVM>();
                foreach (var parca2 in ViewBag.Parca)
                {
                    tramerVMs.Add(new TramerVM { ParcaID = parca2.ParcaID });
                }

                araArac.tramerVMs = tramerVMs;
            }

            return View(araArac);
        }

        [HttpPost]
        public ActionResult AracEkle(AracDBVM arac, string name)
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            var ilanSon = TempData["sonilan"] as Ilanbilgisi;
            TempData["araArac"] = arac;





            if (name== "Kaydet")
            {
                var a = new AracDAL().AracEkle(arac, kullanici.KullaniciID);
                TempData.Remove("araArac");
            }
            else if (name == "Guncelle")
            {
                var a = new AracDAL().AracGuncelle(arac);
                TempData.Remove("araArac");

            }
            else if (name == "Ilan Bilgisi")
            {
                return RedirectToAction("AracDetayIlan");
            }
            else if (name == "Tramer Bilgisi")
            {
                return RedirectToAction("AracDetayTramer");
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult AracDetayTramer(AracDBVM vM)
        {
            KullaniciVM kullanici = Session["kullanici"] as KullaniciVM;
            ViewBag.kul = kullanici;

            TempData["araArac"] = vM;


            TempData["tramereBasldi"] = true;


            return RedirectToAction("AracEkle");
        }
    }
}