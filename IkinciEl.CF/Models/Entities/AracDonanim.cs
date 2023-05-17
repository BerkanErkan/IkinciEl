using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class AracDonanim
    {
        [Key]
        public int AracDonanimID { get; set; }
        public int AracID { get; set; }
        public int DonanimID { get; set; }

        [ForeignKey(nameof(AracID))]
        public Arac Arac { get; set; }
        [ForeignKey(nameof(DonanimID))]
        public Donanim Donanim { get; set; }
    }
}