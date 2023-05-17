namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TramerBilgisiDurum")]
    public partial class TramerBilgisiDurum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TramerBilgisiDurum()
        {
            TramerBilgisi = new HashSet<TramerBilgisi>();
        }

        public int TramerBilgisiDurumID { get; set; }

        public string TramerBilgisiDurumAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TramerBilgisi> TramerBilgisi { get; set; }
    }
}
