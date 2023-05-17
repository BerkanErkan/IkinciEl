using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.VM
{
    public class AracVM
    {

        public int AracID { get; set; }
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public string FirmaAdi { get;set; }
        public string StatuAdi { get; set; }
        public string KaydedenKullanici { get; set; }
        public DateTime KaydetmeZamani { get; set; }

        public string GovdeTipi { get; set; }
        public DateTime Yil { get; set; }
        public string YakitTipi { get; set; }
        public string VitesTipi { get; set; }
        public int KmBilgisi { get; set; }
        public string Renk { get; set; }
        public string IlanBaslıgi { get; set; }
        public string IlanAckilma { get; set; }
        public float AracFiyat { get; set; }
    }
}