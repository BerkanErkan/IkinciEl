using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class SatisTipi
    {
        [Key]
        public int SatisTipiID { get; set; }
        public string SatisTipiAdi { get; set; }

        public List<AracSatis> AracSatis { get; set; }
    }
}