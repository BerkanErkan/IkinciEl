using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.VM
{
    public class TramerVM
    {
        public int TramerID { get; set; }
        public int TramerBilgisiDurumID { get; set; }
        public int ParcaID { get; set; }
        public string ParcaAdi { get; set; }
        public string DurumAdi { get; set; }
    }
}