using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class TramerBilgisiDurum
    {
        [Key]
        public int TramerBilgisiDurumID { get; set; }
        public string TramerBilgisiDurumAdi { get; set; }

        public List<TramerBilgisi> TramerBilgisi { get; set; }
    }
}