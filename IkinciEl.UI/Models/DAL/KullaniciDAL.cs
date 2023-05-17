using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class KullaniciDAL
    {

        Model1 db = new Model1();
        public List<KullaniciVM> KullaniciDoldur(bool onay)
        {

            var result = (from c in db.Kullanici
                          join r in db.Rol on c.RolID equals r.RolID
                          where c.KullaniciOnaylimi == onay
                          select new KullaniciVM
                          {
                              Mail = c.Mail,
                              AdveSoyad = c.AdVeSoyad,
                              YetkiAdi = r.RolAdi,
                               KullaniciID= c.KullaniciID
                          }).ToList();


            

            return result;


        }
        public KurumsalKullaniciVM KullaniciBilgisi(int kullaniciID)
        {
            var result = (from c in db.Kullanici
                          join r in db.Rol on c.RolID equals r.RolID
                          join kk in db.SirketBilgisi on c.SirketBilgisiID equals kk.SirketBİlgisiID
                          where c.KullaniciID == kullaniciID
                          select new KurumsalKullaniciVM()
                          {
                              AdveSoyad= c.AdVeSoyad,
                              KullaniciAdi=c.KullaniciAdi,
                              KullaniciID=c.KullaniciID,
                              KullaniciOnaylimi = c.KullaniciOnaylimi,
                              KurumsalMi = c.KurumsalMi,
                              Mail = c.Mail,
                              PaketID = c.PaketID,
                              YetkiAdi = r.RolAdi,
                              RolID = c.RolID,
                              SirketID=c.SirketBilgisiID,
                              Tel= c.Telefon,
                              SirketAdi = kk.FirmaAdi,
                              SirketAdresi = kk.Adres
                              




                          }).SingleOrDefault();

            return result;


        }
        public List<KullaniciVM> KullanicilarinHepsiniDoldur()
        {

            var result = (from c in db.Kullanici
                          join r in db.Rol on c.RolID equals r.RolID
                          select new KullaniciVM
                          {
                              Mail = c.Mail,
                              AdveSoyad = c.AdVeSoyad,
                               YetkiAdi = r.RolAdi,
                              KullaniciID = c.KullaniciID

                          }).ToList();

            

            return result;


        }
        public List<KullaniciVM> KullaniciRoleGoreDoldur(int rol)
        {

            var result = (from c in db.Kullanici
                          join r in db.Rol on c.RolID equals r.RolID
                          where c.RolID == rol
                          select new KullaniciVM
                          {
                              Mail = c.Mail,
                              AdveSoyad = c.AdVeSoyad,
                              YetkiAdi = r.RolAdi,
                              KullaniciID = c.KullaniciID
                          }).ToList();


            

            return result;


        }
        public bool KullaniciEkle(KurumsalKullaniciVM vM)
        {
            db.Kullanici.Add(new Kullanici()
            { 
                  AdVeSoyad = vM.AdveSoyad,
                 KullaniciAdi = vM.KullaniciAdi,
                 Telefon = vM.Tel,
                Mail = vM.Mail,
                Sifre = vM.Sifre,
                SirketBilgisiID=2,
                PaketID=vM.PaketID,
                RolID=vM.RolID,
                 KullaniciOnaylimi=true,
                  KullaniciAktifmi=true,
                  KurumsalMi=false

            });
            return db.SaveChanges() > 0;


        }
        public bool KurumsalKullaniciEkle(KurumsalKullaniciVM vM)
        {
            SirketBilgisi sirketBilgisi = new SirketBilgisi()
            {
                FirmaAdi = vM.SirketAdi,
                Adres = vM.SirketAdresi,
                FirmaTuruID = vM.FirmaTuruID,
                IlceID = 1
            };
            db.SirketBilgisi.Add(sirketBilgisi);
            db.SaveChanges();

            db.Kullanici.Add(new Kullanici()
            {
                AdVeSoyad = vM.AdveSoyad,
                KullaniciAdi = vM.KullaniciAdi,
                Telefon = vM.Tel,
                Mail = vM.Mail,
                Sifre = vM.Sifre,
                SirketBilgisiID = sirketBilgisi.SirketBİlgisiID,
                PaketID = vM.PaketID,
                RolID = vM.RolID,
                KullaniciOnaylimi = true,
                KullaniciAktifmi = true,
                KurumsalMi=true

            });
            return db.SaveChanges() > 0;


        }

        public bool KullaniciSil(int ID)
        {
            Kullanici silinmekIstenenData = db.Kullanici.SingleOrDefault(a => a.KullaniciID == ID);


            db.Kullanici.Remove(silinmekIstenenData);
            return db.SaveChanges() > 0;




        }

        public bool KullaniciGuncelle(KurumsalKullaniciVM vM)
        {
            Kullanici kullanici = db.Kullanici.SingleOrDefault(a => a.KullaniciID == vM.KullaniciID);
            if (kullanici == null)
            {
                return false;
            }
            kullanici.KullaniciAdi = vM.KullaniciAdi;
            kullanici.KullaniciOnaylimi = vM.KullaniciOnaylimi;
            kullanici.KurumsalMi = vM.KurumsalMi;
            kullanici.AdVeSoyad= vM.AdveSoyad;
            kullanici.KullaniciOnaylimi = vM.KullaniciOnaylimi;
            kullanici.Mail = vM.Mail;
            kullanici.PaketID = vM.PaketID;
            kullanici.RolID = vM.RolID;
            kullanici.Telefon = vM.Tel;


            db.SaveChanges();

            return true;
        }


        public bool KurumsalKullaniciGuncelle(KurumsalKullaniciVM vM)
        {
            SirketBilgisi sirket = db.SirketBilgisi.SingleOrDefault(s => s.SirketBİlgisiID == vM.SirketID);
            if (sirket == null)
            {
                return false;
            }

            sirket.FirmaAdi = vM.SirketAdi;
            sirket.Adres = vM.SirketAdresi;


            Kullanici kullanici = db.Kullanici.SingleOrDefault(a => a.KullaniciID == vM.KullaniciID);
            kullanici.KullaniciAdi = vM.KullaniciAdi;
            kullanici.KullaniciOnaylimi = vM.KullaniciOnaylimi;
            kullanici.KurumsalMi = vM.KurumsalMi;
            kullanici.AdVeSoyad = vM.AdveSoyad;
            kullanici.KullaniciOnaylimi = vM.KullaniciOnaylimi;
            kullanici.Mail = vM.Mail;
            kullanici.PaketID = vM.PaketID;
            kullanici.RolID = vM.RolID;
            kullanici.Telefon = vM.Tel;


            db.SaveChanges();

            return true;
        }



    }
}