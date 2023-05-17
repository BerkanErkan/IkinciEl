using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class AracModel
    {
        [Key]
        public int AracModelID { get; set; }
        public string AracModelAdi { get; set;}
        public int GovdeTipiID { get; set; }

        public List<Arac> Arac { get; set; }

        [ForeignKey(nameof(GovdeTipiID))]
        public GovdeTipi GovdeTipi { get; set; }

    }
}