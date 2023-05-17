using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class VitesTipi
    {
        [Key]
        public int VitesTipiiID { get; set; }
        public string VitesTipiAdi { get; set; }

        public List<Arac> Arac { get; set; }
    }
}