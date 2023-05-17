namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IhaleFiyatKullanici")]
    public partial class IhaleFiyatKullanici
    {
        public int IhaleFiyatKullaniciID { get; set; }

        public int KullaniciID { get; set; }

        public int IhaleFiyatID { get; set; }

        public virtual IhaleFiyat IhaleFiyat { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
