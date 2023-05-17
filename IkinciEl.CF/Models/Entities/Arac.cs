using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Arac
    {
        [Key]
        public int AracID { get; set; }
        public DateTime Yil { get; set; }
        public int Kilometre { get; set; }
        public bool AracOnaylimi { get; set; }
        public DateTime KaydedilmeZamanı { get; set; }
        public string Plaka { get; set; }
        public bool AracAktifmi { get; set; }
        public float AracFiyati { get; set; }
        public int KullaniciID { get; set; }
        public int AracModelID { get; set; }
        public int YakıtTipiID { get; set; }
        public int VitesTipiId { get; set; }
        public int RenkID { get; set; }
        public int IlanbilgisiID { get; set; }
        public int AracMarkaID { get; set; }
        //public int StatuID { get; set; }

        public List<AracDonanim> AracDonanim { get; set; }
        public List<Gorsel> Gorsel { get; set; }
        public List<TramerBilgisi> TramerBilgisi { get; set; }
        public List<Ihale> Ihale { get; set; }
        public List<Favori> Favori { get; set; }
        public List<SattigimArac> SattigimArac { get; set; }
        public List<AldigimArac> AldigimArac { get; set; }
        public List<AracSatis> AracSatis { get; set; }


        [ForeignKey(nameof(AracMarkaID))]
        public AracMarka AracMarka { get; set; }
        [ForeignKey(nameof(KullaniciID))]
        public Kullanici Kullanici { get; set; }
        [ForeignKey(nameof(AracModelID))]
        public AracModel AracModel { get; set; }
        [ForeignKey(nameof(YakıtTipiID))]
        public YakitTipi YakitTipi { get; set; }
        [ForeignKey(nameof(VitesTipiId))]
        public VitesTipi VitesTipi { get; set; }
        [ForeignKey(nameof(RenkID))]
        public Renk Renk { get; set; }
        [ForeignKey(nameof(IlanbilgisiID))]
        public Ilanbilgisi Ilanbilgisi { get; set; }
        //[ForeignKey(nameof(StatuID))]
        //public Statu Statu { get; set; }
    }
}