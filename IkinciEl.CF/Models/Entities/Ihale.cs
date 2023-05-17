using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Ihale
    {
        [Key]
        public int IhaleID { get; set; }
        public string IhaleAdi { get; set; }
        public DateTime IhaleBaslangicTarihi { get; set; }
        public DateTime IhaleBitisTarihi { get; set; }
        public float IhaleBaslangicFiyati { get; set; }
        public float MaxAlimFiyati { get; set; }
        public bool KurumsalMi { get; set; }
        public int KullaniciID { get; set; }
        public int AracID { get; set; }
        public int IhaleStatuID { get; set; }

        public List<IhaleFiyat> IhaleFiyat { get; set; }

        [ForeignKey(nameof(KullaniciID))]
        public Kullanici Kullanici { get; set; }
        [ForeignKey(nameof(AracID))]
        public Arac Arac { get; set; }
        [ForeignKey(nameof(IhaleStatuID))]
        public IhaleStatu IhaleStatu { get; set; }

    }
}