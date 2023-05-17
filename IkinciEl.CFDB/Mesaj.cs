namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mesaj")]
    public partial class Mesaj
    {
        public int MesajID { get; set; }

        public string MesajIcerik { get; set; }

        public int KullaniciID { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
