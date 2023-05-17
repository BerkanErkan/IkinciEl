using IkinciEl.CF.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class IhaleFiyat
    {
        [Key]
        public int IhaleFiyatID { get; set; }
        public float Fiyat { get; set; }
        public int SiraNo { get; set; }
        public int KullaniciID { get; set; }
        public int IhaleID { get; set; }
        public List<IhaleFiyatKullanici> IhaleFiyatKullanicis { get; set; }


        //[ForeignKey(nameof(KullaniciID))]
        //public List<Kullanici> Kullanici { get; set; }
        [ForeignKey(nameof(IhaleID))]
        public Ihale Ihale { get; set; }

    }
}