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
    
    public partial class Arac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arac()
        {
            this.AldigimArac = new HashSet<AldigimArac>();
            this.AracDonanim = new HashSet<AracDonanim>();
            this.AracSatis = new HashSet<AracSatis>();
            this.Favori = new HashSet<Favori>();
            this.Gorsel = new HashSet<Gorsel>();
            this.Ihale = new HashSet<Ihale>();
            this.SattigimArac = new HashSet<SattigimArac>();
            this.TramerBilgisi = new HashSet<TramerBilgisi>();
        }
    
        public int AracID { get; set; }
        public System.DateTime Yil { get; set; }
        public int Kilometre { get; set; }
        public bool AracOnaylimi { get; set; }
        public System.DateTime KaydedilmeZamanı { get; set; }
        public string Plaka { get; set; }
        public bool AracAktifmi { get; set; }
        public float AracFiyati { get; set; }
        public int KullaniciID { get; set; }
        public int AracModelID { get; set; }
        public int YakıtTipiID { get; set; }
        public int VitesTipiId { get; set; }
        public int RenkID { get; set; }
        public int IlanbilgisiID { get; set; }
        public int AracMarkaID { get; set; }
        public Nullable<int> StatuID { get; set; }
        public Nullable<bool> KurumsalMİ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AldigimArac> AldigimArac { get; set; }
        public virtual Statu Statu { get; set; }
        public virtual AracMarka AracMarka { get; set; }
        public virtual AracModel AracModel { get; set; }
        public virtual Ilanbilgisi Ilanbilgisi { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Renk Renk { get; set; }
        public virtual VitesTipi VitesTipi { get; set; }
        public virtual YakitTipi YakitTipi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracDonanim> AracDonanim { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracSatis> AracSatis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favori> Favori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gorsel> Gorsel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ihale> Ihale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SattigimArac> SattigimArac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TramerBilgisi> TramerBilgisi { get; set; }
    }
}
