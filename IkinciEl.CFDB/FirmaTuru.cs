namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FirmaTuru")]
    public partial class FirmaTuru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FirmaTuru()
        {
            SirketBilgisi = new HashSet<SirketBilgisi>();
        }

        public int FirmaTuruID { get; set; }

        public string FiirmaTuruAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SirketBilgisi> SirketBilgisi { get; set; }
    }
}
