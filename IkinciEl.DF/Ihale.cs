//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IkinciEl.DF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ihale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ihale()
        {
            this.IhaleFiyat = new HashSet<IhaleFiyat>();
        }
    
        public int IhaleID { get; set; }
        public string IhaleAdi { get; set; }
        public System.DateTime IhaleBaslangicTarihi { get; set; }
        public System.DateTime IhaleBitisTarihi { get; set; }
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
