namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gorsel")]
    public partial class Gorsel
    {
        public int GorselID { get; set; }

        public string GorselAdresi { get; set; }

        public int AracID { get; set; }

        public virtual Arac Arac { get; set; }
    }
}
