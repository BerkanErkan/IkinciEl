using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class NoterUcret
    {
        [Key]
        public int NoterUcretID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public float Ucret { get; set; }
    }
}