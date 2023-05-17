namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IhaleStatu")]
    public partial class IhaleStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IhaleStatu()
        {
            Ihale = new HashSet<Ihale>();
        }

        public int IhaleStatuID { get; set; }

        public string IhaleStatuAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ihale> Ihale { get; set; }
    }
}
