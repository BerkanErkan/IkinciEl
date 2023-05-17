namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SirketBilgisi")]
    public partial class SirketBilgisi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SirketBilgisi()
        {
            Kullanici = new HashSet<Kullanici>();
        }

        [Key]
        public int SirketBİlgisiID { get; set; }

        public string FirmaAdi { get; set; }

        public string Adres { get; set; }

        public int FirmaTuruID { get; set; }

        public int? IlceID { get; set; }

        public virtual FirmaTuru FirmaTuru { get; set; }

        public virtual Ilce Ilce { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kullanici> Kullanici { get; set; }
    }
}
