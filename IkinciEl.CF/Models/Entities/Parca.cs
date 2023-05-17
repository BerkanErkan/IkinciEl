using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Parca
    {
        [Key]
        public int ParcaID { get; set; }
        public string ParcaAdi { get; set; }

        public List<TramerBilgisi> TramerBilgisi { get; set; }
    }
}