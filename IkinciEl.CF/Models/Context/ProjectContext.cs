using IkinciEl.CF.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext() : base("server=.;Database=IkinciElArac;Trusted_Connection=True")
        {
            this.Configuration.LazyLoadingEnabled = false;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Arac>()
               .HasRequired(a => a.Kullanici)
               .WithMany(k => k.Arac)
               .HasForeignKey(a => a.KullaniciID)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeklifVerdigimArac>()
                .HasRequired(t => t.Kullanici)
                .WithMany(k => k.TeklifVerdigimArac)
                .HasForeignKey(t => t.KullaniciID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IhaleFiyatKullanici>()
                .HasRequired(ik => ik.Kullanici)
                .WithMany(k => k.IhaleFiyatKullanicis)
                .HasForeignKey(ik => ik.KullaniciID)
                .WillCascadeOnDelete(false);

        }
        

        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<AldigimArac> AldigimAracs { get; set; }
        public DbSet<Arac> Aracs { get; set; }
        public DbSet<AracDonanim> AracDonanims { get; set; }
        public DbSet<AracMarka> AracMarkas { get; set; }
        public DbSet<AracModel> AracModels { get; set; }
        public DbSet<AracSatis> AracSatis { get; set; }
        public DbSet<Donanim> Donanims { get; set; }
        public DbSet<ExpertizMerkez> ExpertizMerkezs { get; set; }
        public DbSet<Favori> Favoris { get; set; }
        public DbSet<FirmaTuru> FirmaTurus { get; set; }
        public DbSet<Gorsel> Gorsels { get; set; }
        public DbSet<GovdeTipi> GovdeTipis { get; set; }
        public DbSet<Ihale> Ihales { get; set; }
        public DbSet<IhaleFiyat> IhaleFiyats { get; set; }
        public DbSet<IhaleStatu> IhaleStatus { get; set; }
        public DbSet<Ilanbilgisi> Ilanbilgisis { get; set; }
        public DbSet<Komisyon> Komisyons { get; set; }
        public DbSet<Mesaj> Mesajs { get; set; }
        public DbSet<NoterUcret> NoterUcrets { get; set; }
        public DbSet<Paket> Pakets { get; set; }
        public DbSet<Parca> Parcas { get; set; }
        public DbSet<Renk> Renks { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<SatisTipi> SatisTipis { get; set; }
        public DbSet<SattigimArac> SattigimAracs { get; set; }
        public DbSet<SirketBilgisi> SirketBilgisis { get; set; }
        public DbSet<Statu> Status { get; set; }
        public DbSet<StatuTipi> StatuTipis { get; set; }
        public DbSet<TeklifVerdigimArac> TeklifVerdigimAracs { get; set; }
        public DbSet<TramerBilgisi> TramerBilgisis { get; set; }
        public DbSet<TramerBilgisiDurum> TramerBilgisiDurums { get; set; }
        public DbSet<VitesTipi> VitesTipis { get; set; }
        public DbSet<YakitTipi> YakitTipis { get; set; }


    }
}