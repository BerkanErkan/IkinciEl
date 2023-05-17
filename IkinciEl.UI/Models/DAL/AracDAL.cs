using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class AracDAL
    {
        Model1 db = new Model1();

        public List<AracVM> AraclarinepsiniDoldur()
        {
            var result = (from c in db.Arac
                          join ma in db.AracMarka on c.AracMarkaID equals ma.AracMarkaID
                          join mo in db.AracModel on c.AracModelID equals mo.AracModelID
                          join ku in db.Kullanici on c.KullaniciID equals ku.KullaniciID
                          join si in db.SirketBilgisi on ku.SirketBilgisiID equals si.SirketBİlgisiID
                          //join sta in db.Status on c.StatuID equals sta.StatuID
                          //join statip in db.StatuTipis on sta.StatuTipiID equals statip.StatuTipiID
                          select new AracVM()
                          {
                               AracID = c.AracID,
                               AracMarka = ma.AracMarkaAdi,
                               AracModel = mo.AracModelAdi,
                               KaydedenKullanici = ku.KullaniciAdi,
                               KaydetmeZamani = c.KaydedilmeZamanı,
                               FirmaAdi = si.FirmaAdi
                               //StatuAdi = statip.StatuTipiAdi
                          }).ToList();

            return result;


        }

        public List<AracVM> AracDoldur(bool onay)
        {

            var result = (from c in db.Arac
                          join ma in db.AracMarka on c.AracMarkaID equals ma.AracMarkaID
                          join mo in db.AracModel on c.AracModelID equals mo.AracModelID
                          join ku in db.Kullanici on c.KullaniciID equals ku.KullaniciID
                          join si in db.SirketBilgisi on ku.SirketBilgisiID equals si.SirketBİlgisiID
                          where c.AracOnaylimi == onay
                          select new AracVM
                          {
                              AracID = c.AracID,
                              AracMarka = ma.AracMarkaAdi,
                              AracModel = mo.AracModelAdi,
                              KaydedenKullanici = ku.KullaniciAdi,
                              KaydetmeZamani = c.KaydedilmeZamanı,
                              FirmaAdi = si.FirmaAdi

                          }).ToList();




            return result;


        }
        public List<AracVM> AraclariDoldur(int markaID, int modelID)
        {
            var result = (from c in db.Arac
                          join ma in db.AracMarka on c.AracMarkaID equals ma.AracMarkaID
                          join mo in db.AracModel on c.AracModelID equals mo.AracModelID
                          join ku in db.Kullanici on c.KullaniciID equals ku.KullaniciID
                          join si in db.SirketBilgisi on ku.SirketBilgisiID equals si.SirketBİlgisiID
                          where c.AracMarkaID==markaID && c.AracModelID==modelID
                          select new AracVM()
                          {
                              AracID = c.AracID,
                              AracMarka = ma.AracMarkaAdi,
                              AracModel = mo.AracModelAdi,
                              KaydedenKullanici = ku.KullaniciAdi,
                              KaydetmeZamani = c.KaydedilmeZamanı,
                              FirmaAdi = si.FirmaAdi,
                                
                              //StatuAdi = statip.StatuTipiAdi
                          }).ToList();

            return result;


        }
        public AracDBVM AraciDoldur(int aracID)
        {
            var result = (from c in db.Arac
                          join ma in db.AracMarka on c.AracMarkaID equals ma.AracMarkaID
                          join mo in db.AracModel on c.AracModelID equals mo.AracModelID
                          join ku in db.Kullanici on c.KullaniciID equals ku.KullaniciID
                          join si in db.SirketBilgisi on ku.SirketBilgisiID equals si.SirketBİlgisiID
                          join go in db.GovdeTipi on mo.GovdeTipiID equals go.GovdeTipiID
                          join ilan in db.Ilanbilgisi on c.IlanbilgisiID equals ilan.IlanbilgisiID
                          join re in db.Renk on c.RenkID equals re.RenkID
                          join vi in db.VitesTipi on c.VitesTipiId equals vi.VitesTipiiID
                          join ya in db.YakitTipi on c.YakıtTipiID equals ya.YakitTipiID
                          where c.AracID == aracID
                          select new AracDBVM()
                          {
                              
                              AracMarkaID = c.AracMarkaID,
                              AracModelID = c.AracModelID,
                              KullaniciID = c.KullaniciID,
                              IlanbilgisiID = c.IlanbilgisiID,
                              Kilometre=c.Kilometre,
                              RenkID=c.RenkID,
                              VitesTipiId=c.VitesTipiId,
                              YakıtTipiID=c.YakıtTipiID,
                              Yil=c.Yil,
                              KurumsalMİ=c.KurumsalMİ,
                              AracFiyati=c.AracFiyati,
                              DonanimID=c.DonanimID,
                              Plaka=c.Plaka,
                              AracID=c.AracID,
                              IlanBaslıgi= ilan.IlanBasligi,
                              IlanAckilma= ilan.IlanAciklama,
                               OnayliMi=c.AracOnaylimi,
                                GovdeTipiID=mo.GovdeTipiID

                              //StatuAdi = statip.StatuTipiAdi
                          }).SingleOrDefault();

            result.tramerVMs = AracinTramerBilgileriDoldur(result.AracID);


            return result;


        }
        public List<TramerVM> AracinTramerBilgileriDoldur(int aracID)
        {
            var result = (from c in db.Arac
                          join tra in db.TramerBilgisi on c.AracID equals tra.AracID
                          join pa in db.Parca on tra.ParcaID equals pa.ParcaID
                          where c.AracID == aracID
                          select new TramerVM()
                          {
                               TramerBilgisiDurumID=tra.TramerBilgisiDurumID,
                               ParcaAdi=pa.ParcaAdi,
                                TramerID= tra.TramerBilgisiID,
                                 ParcaID=tra.ParcaID
                                  

                          }).ToList();



            return result;


        }

        public bool AracEkle(AracDBVM vM, int kullaniciID)
        {
            
            Ilanbilgisi ilanBilgisi = new Ilanbilgisi()
            {
                 IlanBasligi = vM.IlanBaslıgi,
                 IlanAciklama = vM.IlanAckilma
            };
            db.Ilanbilgisi.Add(ilanBilgisi);
            db.SaveChanges();


            Arac arac = new Arac()
            {
                Yil = DateTime.Now,
                Kilometre = vM.Kilometre,
                AracOnaylimi = true,
                KaydedilmeZamanı = DateTime.Now,
                Plaka = vM.Plaka,
                AracAktifmi = true,
                AracFiyati = vM.AracFiyati,
                KullaniciID = kullaniciID,
                AracModelID = vM.AracModelID,
                YakıtTipiID = vM.YakıtTipiID,
                VitesTipiId = vM.VitesTipiId,
                RenkID = vM.RenkID,
                IlanbilgisiID = ilanBilgisi.IlanbilgisiID,
                AracMarkaID = vM.AracMarkaID,
                KurumsalMİ = vM.KurumsalMİ,
                DonanimID = vM.DonanimID
            };
            db.Arac.Add(arac);
            db.SaveChanges();


            foreach (var item in vM.tramerVMs)
            {

                db.TramerBilgisi.Add(new TramerBilgisi()
                {
                      AracID=arac.AracID,
                      ParcaID=item.ParcaID,
                      TramerBilgisiDurumID=item.TramerBilgisiDurumID



                });
                db.SaveChanges();



            }





            return db.SaveChanges() > 0;


        }

        public bool AracGuncelle(AracDBVM vM)
        {

            Ilanbilgisi ilan = db.Ilanbilgisi.SingleOrDefault(s => s.IlanbilgisiID == vM.IlanbilgisiID);
            if (ilan == null)
            {
                return false;
            }
            ilan.IlanBasligi = vM.IlanBaslıgi;
            ilan.IlanAciklama = vM.IlanAckilma;



            for (int i = 0; i < vM.tramerVMs.Count; i++)
            {

                if (vM.tramerVMs[i].TramerID != 0)
                {
                    int ID = Convert.ToInt32(vM.tramerVMs[i].TramerID);


                    TramerBilgisi tramer = db.TramerBilgisi.SingleOrDefault(s => s.TramerBilgisiID == ID);

                    tramer.TramerBilgisiDurumID = vM.tramerVMs[i].TramerBilgisiDurumID;
                    db.SaveChanges();
                }
                else
                {

                    db.TramerBilgisi.Add(new TramerBilgisi()
                    {
                        AracID = vM.AracID,
                        ParcaID = vM.tramerVMs[i].ParcaID,
                        TramerBilgisiDurumID = vM.tramerVMs[i].TramerBilgisiDurumID



                    });
                    db.SaveChanges();




                }






            }




            Arac arac = db.Arac.SingleOrDefault(a => a.AracID == vM.AracID);
            arac.Kilometre = vM.Kilometre;
            arac.Plaka = vM.Plaka;
            arac.AracFiyati = vM.AracFiyati;
            arac.AracModelID = vM.AracModelID;
            arac.YakıtTipiID = vM.YakıtTipiID;
            arac.VitesTipiId = vM.VitesTipiId;
            arac.RenkID = vM.RenkID;
            arac.AracMarkaID = vM.AracMarkaID;
            arac.KurumsalMİ = vM.KurumsalMİ;
            arac.DonanimID = vM.DonanimID;
            arac.AracOnaylimi = vM.OnayliMi;

            return db.SaveChanges() > 0;
            
        }

        



    }
}