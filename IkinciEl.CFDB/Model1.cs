using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IkinciEl.CFDB
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("server=.;Database=IkinciElArac;Trusted_Connection=True")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AldigimArac> AldigimArac { get; set; }
        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<AracMarka> AracMarka { get; set; }
        public virtual DbSet<AracModel> AracModel { get; set; }
        public virtual DbSet<AracSatis> AracSatis { get; set; }
        public virtual DbSet<Donanim> Donanim { get; set; }
        public virtual DbSet<ExpertizMerkez> ExpertizMerkez { get; set; }
        public virtual DbSet<Favori> Favori { get; set; }
        public virtual DbSet<FirmaTuru> FirmaTuru { get; set; }
        public virtual DbSet<Gorsel> Gorsel { get; set; }
        public virtual DbSet<GovdeTipi> GovdeTipi { get; set; }
        public virtual DbSet<Ihale> Ihale { get; set; }
        public virtual DbSet<IhaleFiyat> IhaleFiyat { get; set; }
        public virtual DbSet<IhaleFiyatKullanici> IhaleFiyatKullanici { get; set; }
        public virtual DbSet<IhaleStatu> IhaleStatu { get; set; }
        public virtual DbSet<Ilanbilgisi> Ilanbilgisi { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<Komisyon> Komisyon { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Mesaj> Mesaj { get; set; }
        public virtual DbSet<NoterUcret> NoterUcret { get; set; }
        public virtual DbSet<Paket> Paket { get; set; }
        public virtual DbSet<Parca> Parca { get; set; }
        public virtual DbSet<Renk> Renk { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<SatisTipi> SatisTipi { get; set; }
        public virtual DbSet<SattigimArac> SattigimArac { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<SirketBilgisi> SirketBilgisi { get; set; }
        public virtual DbSet<Statu> Statu { get; set; }
        public virtual DbSet<StatuTipi> StatuTipi { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TeklifVerdigimArac> TeklifVerdigimArac { get; set; }
        public virtual DbSet<TramerBilgisi> TramerBilgisi { get; set; }
        public virtual DbSet<TramerBilgisiDurum> TramerBilgisiDurum { get; set; }
        public virtual DbSet<VitesTipi> VitesTipi { get; set; }
        public virtual DbSet<YakitTipi> YakitTipi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Arac)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.AracSatis)
                .WithRequired(e => e.Kullanici)
                .HasForeignKey(e => e.KullanıcıID);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.IhaleFiyatKullanici)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.TeklifVerdigimArac)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SirketBilgisi>()
                .HasMany(e => e.Kullanici)
                .WithRequired(e => e.SirketBilgisi)
                .HasForeignKey(e => e.SirketBilgisiID);

            modelBuilder.Entity<VitesTipi>()
                .HasMany(e => e.Arac)
                .WithRequired(e => e.VitesTipi)
                .HasForeignKey(e => e.VitesTipiId);

            modelBuilder.Entity<YakitTipi>()
                .HasMany(e => e.Arac)
                .WithRequired(e => e.YakitTipi)
                .HasForeignKey(e => e.YakıtTipiID);
        }
    }
}
