using IkinciEl.CF.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string AdVeSoyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public bool KullaniciAktifmi { get; set; }
        public string Sifre { get; set; }
        public int ToplamIhaleAracSayisi { get; set; }
        public bool KullaniciOnaylimi { get; set; }
        public bool KVKKTiklimi { get; set; }
        public int RolID { get; set; }
        public int PaketID { get; set; }
        public int SirketBilgisiID { get; set; }

        public List<Statu> Statu { get; set; }
        public List<Arac> Arac { get; set; }
        public List<SatisTipi> SatisTipi { get; set; }
        public List<Ihale> Ihale { get; set; }
        //public List<IhaleFiyat> IhaleFiyat { get; set; }
        public List<Favori> Favori { get; set; }
        public List<SattigimArac> SattigimArac { get; set; }
        public List<AldigimArac> AldigimArac { get; set; }
        public List<Mesaj> Mesaj { get; set; }
        public List<TeklifVerdigimArac> TeklifVerdigimArac { get; set; }
        public List<IhaleFiyatKullanici> IhaleFiyatKullanicis { get; set; }

        [ForeignKey(nameof(PaketID))]
        public Paket Paket { get; set; }
        [ForeignKey(nameof(RolID))]
        public Rol Rol { get; set; }
        [ForeignKey(nameof(SirketBilgisiID))]
        public SirketBilgisi SirketBilgisi { get; set; }
    }
}