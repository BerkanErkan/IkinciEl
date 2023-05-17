using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class AracMarka
    {
        [Key]
        public int AracMarkaID { get; set; }
        public string AracMarkaAdi { get; set; }

        public List<Arac> Aracs { get; set; }

    }
}