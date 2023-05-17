using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class TramerBilgisi
    {
        [Key]
        public int TramerBilgisiID { get; set; }
        public int TramerBilgisiDurumID { get; set; }
        public int ParcaID { get; set; }
        public int AracID { get; set; }

        [ForeignKey(nameof(TramerBilgisiDurumID))]
        public TramerBilgisiDurum TramerBilgisiDurum { get; set; }
        [ForeignKey(nameof(AracID))]
        public Arac Arac { get; set; }
        [ForeignKey(nameof(ParcaID))]
        public Parca Parca { get; set; }
    }
}