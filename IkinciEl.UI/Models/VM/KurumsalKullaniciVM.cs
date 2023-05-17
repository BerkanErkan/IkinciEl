using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.VM
{
    public class KurumsalKullaniciVM
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Tel { get; set; }
        public string AdveSoyad { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public string YetkiAdi { get; set; }
        public int SirketID { get; set; }
        public string SirketAdi { get; set; }
        public string SirketAdresi { get; set; }
        public int FirmaTuruID { get; set; }
        public int IlceID { get; set; }
        public bool KullaniciOnaylimi { get; set; }
        public int RolID { get; set; }
        public int PaketID { get; set; }
        public bool? KurumsalMi { get; set; }

    }
}