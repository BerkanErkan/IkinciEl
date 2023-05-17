using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Renk
    {
        [Key]
        public int RenkID { get; set; }
        public string RenkAdi { get; set; }

        public List<Arac> Arac { get; set; }
    }
}