using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class SirketBilgisi
    {
        [Key]
        public int SirketBİlgisiID { get; set; }
        public string FirmaAdi { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public int FirmaTuruID { get; set; }

        public List<Kullanici> Kullanici { get; set; }
        [ForeignKey(nameof(FirmaTuruID))]
        public FirmaTuru FirmaTuru { get; set; }
    }
}