using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.VM
{
    public class KullaniciVM
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Tel { get; set; }
        public string AdveSoyad { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public string YetkiAdi { get; set; }
        public bool KullaniciOnaylimi { get; set; }
        public int RolID { get; set; }
        public int PaketID { get; set; }
        public int SirketBilgisiID { get; set; }
        public bool? KurumsalMi { get; set; }


        public override string ToString()
        {
            return AdveSoyad;
        }
    }
}