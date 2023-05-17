namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Komisyon")]
    public partial class Komisyon
    {
        public int KomisyonID { get; set; }

        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public float MaxFiyat { get; set; }

        public float MinFiyat { get; set; }
    }
}
