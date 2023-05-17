using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Ilanbilgisi
    {
        [Key]
        public int IlanbilgisiID { get; set; }
        public string IlanBasligi { get; set; }
        public string IlanAciklama { get; set; }


    }
}