using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.VM
{
    public class AracDBVM
    {
        public AracDBVM()
        {
            
        }

        public int AracID { get; set; }
        public DateTime Yil { get; set; }

        public int Kilometre { get; set; }

        public string Plaka { get; set; }

        public float AracFiyati { get; set; }

        public int KullaniciID { get; set; }

        public int AracModelID { get; set; }

        public int YakıtTipiID { get; set; }

        public int VitesTipiId { get; set; }

        public int RenkID { get; set; }

        public int? IlanbilgisiID { get; set; }

        public int AracMarkaID { get; set; }

        public bool? KurumsalMİ { get; set; }
        public int SirketID { get; set; }
        public int? DonanimID { get; set; }
        public int GovdeTipiID { get; set; }
        public string GovdeTipi { get; set; }
        public string YakitTipi { get; set; }
        public string VitesTipi { get; set; }
        public string Renk { get; set; }
        public string IlanBaslıgi { get; set; }
        public string IlanAckilma { get; set; }
        public bool OnayliMi { get; set; }
        public string StatuAdi { get; set; }
        public int StatuID { get; set; }
        public List<TramerVM> tramerVMs { get; set; }

    }
}