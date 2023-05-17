using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Donanim
    {
        [Key]
        public int DonanimID { get; set; }
        public string DonanimAdi { get; set; }

        public List<AracDonanim> AracDonanim { get; set; }
    }
}