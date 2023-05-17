using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Komisyon
    {
        [Key]
        public int KomisyonID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public float MaxFiyat { get; set; }
        public float MinFiyat { get; set; }
    }
}