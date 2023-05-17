using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class GovdeTipi
    {
        [Key]
        public int GovdeTipiID { get; set; }
        public string GovdeTipiAdi { get; set; }

        public List<AracModel> AracModel { get; set; }

    }
}