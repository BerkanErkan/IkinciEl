using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Gorsel
    {
        [Key]
        public int GorselID { get; set; }
        public string GorselAdresi { get; set; }
        public int AracID { get; set; }

        [ForeignKey(nameof(AracID))]
        public Arac Arac { get; set; }
    }
}