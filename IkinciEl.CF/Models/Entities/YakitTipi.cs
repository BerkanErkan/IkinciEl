using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class YakitTipi
    {
        [Key]
        public int YakitTipiID { get; set; }
        public string YakitTipiAdi { get; set; }

        public List<Arac> Arac { get; set; }
    }
}