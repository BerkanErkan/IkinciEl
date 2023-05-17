namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeklifVerdigimArac")]
    public partial class TeklifVerdigimArac
    {
        public int TeklifVerdigimAracId { get; set; }

        public int KullaniciID { get; set; }

        public int IhaleFiyatID { get; set; }

        public virtual IhaleFiyat IhaleFiyat { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
