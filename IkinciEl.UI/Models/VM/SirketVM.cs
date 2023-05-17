using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.VM
{
    public class SirketVM
    {
        public int SirketID { get; set; }
        public string SirketAdi { get; set; }
        public string SirketAdresi { get; set; }
        public int FirmaTuruID { get; set; }
        public int IlceID { get; set; }
    }
}