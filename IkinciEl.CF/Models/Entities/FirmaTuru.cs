using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class FirmaTuru
    {
        [Key]
        public int FirmaTuruID { get; set; }
        public string FiirmaTuruAdi { get; set; }

        public List<SirketBilgisi> SirketBilgisi { get; set; }
    }
}