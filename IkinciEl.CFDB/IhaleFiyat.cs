namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IhaleFiyat")]
    public partial class IhaleFiyat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IhaleFiyat()
        {
            IhaleFiyatKullanici = new HashSet<IhaleFiyatKullanici>();
            TeklifVerdigimArac = new HashSet<TeklifVerdigimArac>();
        }

        public int IhaleFiyatID { get; set; }

        public float Fiyat { get; set; }

        public int SiraNo { get; set; }

        public int KullaniciID { get; set; }

        public int IhaleID { get; set; }

        public virtual Ihale Ihale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleFiyatKullanici> IhaleFiyatKullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeklifVerdigimArac> TeklifVerdigimArac { get; set; }
    }
}
