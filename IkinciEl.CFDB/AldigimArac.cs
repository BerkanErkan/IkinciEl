namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AldigimArac")]
    public partial class AldigimArac
    {
        public int AldigimAracId { get; set; }

        public DateTime AldigimTarih { get; set; }

        public int KullaniciID { get; set; }

        public int AracID { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
