using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class AracSatis
    {
        [Key]
        public int AracSatisID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public float SatinAlinanFiyat { get; set; }
        public int AracID { get; set; }
        public int KullanıcıID { get; set; }
        public int SatisTipiID { get; set; }

        [ForeignKey(nameof(SatisTipiID))]
        public SatisTipi SatisTipi { get; set; }
        [ForeignKey(nameof(KullanıcıID))]
        public Kullanici Kullanici { get; set; }
        [ForeignKey(nameof(AracID))]
        public Arac Arac { get; set; }
    }
}