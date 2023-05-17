namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TramerBilgisi")]
    public partial class TramerBilgisi
    {
        public int TramerBilgisiID { get; set; }

        public int TramerBilgisiDurumID { get; set; }

        public int ParcaID { get; set; }

        public int AracID { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Parca Parca { get; set; }

        public virtual TramerBilgisiDurum TramerBilgisiDurum { get; set; }
    }
}
