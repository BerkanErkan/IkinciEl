using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Statu
    {
        [Key]
        public int StatuID { get; set; }
        public DateTime Tarih { get; set; }
        public int StatuTipiID { get; set; }
        public int KullaniciID { get; set; }

        //public List<Arac> Arac { get; set; }

        [ForeignKey(nameof(StatuTipiID))]
        public StatuTipi StatuTipi { get; set; }
        [ForeignKey(nameof(KullaniciID))]
        public Kullanici Kullanici { get; set; }
    }
}