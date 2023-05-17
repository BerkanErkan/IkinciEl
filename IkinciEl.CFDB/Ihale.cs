namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ihale")]
    public partial class Ihale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ihale()
        {
            IhaleFiyat = new HashSet<IhaleFiyat>();
        }

        public int IhaleID { get; set; }

        public string IhaleAdi { get; set; }

        public DateTime IhaleBaslangicTarihi { get; set; }

        public DateTime IhaleBitisTarihi { get; set; }

        public float IhaleBaslangicFiyati { get; set; }

        public float MaxAlimFiyati { get; set; }

        public bool KurumsalMi { get; set; }

        public int KullaniciID { get; set; }

        public int AracID { get; set; }

        public int IhaleStatuID { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual IhaleStatu IhaleStatu { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleFiyat> IhaleFiyat { get; set; }
    }
}
