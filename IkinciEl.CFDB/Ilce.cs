namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ilce")]
    public partial class Ilce
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ilce()
        {
            SirketBilgisi = new HashSet<SirketBilgisi>();
        }

        public int IlceID { get; set; }

        [StringLength(50)]
        public string IlceAdi { get; set; }

        public int? SehirID { get; set; }

        public virtual Sehir Sehir { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SirketBilgisi> SirketBilgisi { get; set; }
    }
}
