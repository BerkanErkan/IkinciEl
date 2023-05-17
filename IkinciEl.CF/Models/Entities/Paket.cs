using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Paket
    {
        [Key]
        public int PaketID { get; set; }
        public string PaketAdi { get; set; }
        public int IhaledekiMaxAracSayasi { get; set; }

        public List<Kullanici> Kullanici { get; set; }
    }
}