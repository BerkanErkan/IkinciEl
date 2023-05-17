namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AracSatis
    {
        public int AracSatisID { get; set; }

        public DateTime SatisTarihi { get; set; }

        public float SatinAlinanFiyat { get; set; }

        public int AracID { get; set; }

        public int KullanıcıID { get; set; }

        public int SatisTipiID { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual SatisTipi SatisTipi { get; set; }
    }
}
