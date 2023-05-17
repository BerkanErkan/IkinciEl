namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Statu")]
    public partial class Statu
    {
        public int StatuID { get; set; }

        public DateTime Tarih { get; set; }

        public int StatuTipiID { get; set; }

        public int KullaniciID { get; set; }

        public int? AracID { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual StatuTipi StatuTipi { get; set; }
    }
}
