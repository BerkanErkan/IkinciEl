namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arac")]
    public partial class Arac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arac()
        {
            AldigimArac = new HashSet<AldigimArac>();
            AracSatis = new HashSet<AracSatis>();
            Favori = new HashSet<Favori>();
            Gorsel = new HashSet<Gorsel>();
            Ihale = new HashSet<Ihale>();
            SattigimArac = new HashSet<SattigimArac>();
            TramerBilgisi = new HashSet<TramerBilgisi>();
            Statu = new HashSet<Statu>();
        }

        public int AracID { get; set; }

        public DateTime Yil { get; set; }

        public int Kilometre { get; set; }

        public bool AracOnaylimi { get; set; }

        public DateTime KaydedilmeZamanı { get; set; }

        public string Plaka { get; set; }

        public bool AracAktifmi { get; set; }

        public float AracFiyati { get; set; }

        public int KullaniciID { get; set; }

        public int AracModelID { get; set; }

        public int YakıtTipiID { get; set; }

        public int VitesTipiId { get; set; }

        public int RenkID { get; set; }

        public int? IlanbilgisiID { get; set; }

        public int AracMarkaID { get; set; }

        public bool? KurumsalMİ { get; set; }

        public int? DonanimID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AldigimArac> AldigimArac { get; set; }

        public virtual Donanim Donanim { get; set; }

        public virtual AracMarka AracMarka { get; set; }

        public virtual AracModel AracModel { get; set; }

        public virtual Ilanbilgisi Ilanbilgisi { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Renk Renk { get; set; }

        public virtual VitesTipi VitesTipi { get; set; }

        public virtual YakitTipi YakitTipi { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Statu> Statu { get; set; }
    }
}
