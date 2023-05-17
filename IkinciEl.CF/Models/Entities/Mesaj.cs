using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Mesaj
    {
        [Key]
        public int MesajID { get; set; }
        public string MesajIcerik { get; set; }
        public int KullaniciID { get; set; }

        [ForeignKey(nameof(KullaniciID))]
        public Kullanici Kullanici { get; set; }
    }
}