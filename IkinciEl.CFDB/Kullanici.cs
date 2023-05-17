namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            AldigimArac = new HashSet<AldigimArac>();
            Arac = new HashSet<Arac>();
            AracSatis = new HashSet<AracSatis>();
            Favori = new HashSet<Favori>();
            Ihale = new HashSet<Ihale>();
            IhaleFiyatKullanici = new HashSet<IhaleFiyatKullanici>();
            Mesaj = new HashSet<Mesaj>();
            SattigimArac = new HashSet<SattigimArac>();
            Statu = new HashSet<Statu>();
            TeklifVerdigimArac = new HashSet<TeklifVerdigimArac>();
        }

        public int KullaniciID { get; set; }

        public string KullaniciAdi { get; set; }

        public string AdVeSoyad { get; set; }

        public string Telefon { get; set; }

        public string Mail { get; set; }

        public bool KullaniciAktifmi { get; set; }

        public string Sifre { get; set; }

        public int ToplamIhaleAracSayisi { get; set; }

        public bool KullaniciOnaylimi { get; set; }

        public bool KVKKTiklimi { get; set; }

        public int RolID { get; set; }

        public int PaketID { get; set; }

        public int SirketBilgisiID { get; set; }

        public bool? KurumsalMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AldigimArac> AldigimArac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arac> Arac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracSatis> AracSatis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favori> Favori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ihale> Ihale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleFiyatKullanici> IhaleFiyatKullanici { get; set; }

        public virtual Paket Paket { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual SirketBilgisi SirketBilgisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesaj> Mesaj { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SattigimArac> SattigimArac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Statu> Statu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeklifVerdigimArac> TeklifVerdigimArac { get; set; }
    }
}
