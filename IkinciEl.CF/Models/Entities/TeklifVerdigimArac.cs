using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class TeklifVerdigimArac
    {
        [Key]
        public int TeklifVerdigimAracId { get; set; }
        public int KullaniciID { get; set; }
        public int IhaleFiyatID { get; set; }

        [ForeignKey(nameof(KullaniciID))]
        public Kullanici Kullanici { get; set; }
        [ForeignKey(nameof(IhaleFiyatID))]
        public IhaleFiyat IhaleFiyat { get; set; }
    }
}