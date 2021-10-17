namespace OdafHesapProgrami.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model")
        {
        }

        public virtual DbSet<AkimGerilim> AkimGerilim { get; set; }
        public virtual DbSet<Cekirdek> Cekirdek { get; set; }
        public virtual DbSet<DBRoot> DBRoot { get; set; }
        public virtual DbSet<HesapSonuc> HesapSonuc { get; set; }
        public virtual DbSet<Mesafe> Mesafe { get; set; }
        public virtual DbSet<ODAF> ODAF { get; set; }
        public virtual DbSet<ProjeGenel> ProjeGenel { get; set; }
        public virtual DbSet<Sargi> Sargi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AkimGerilim>()
                .Property(e => e.SargıPozisyonNumarasi)
                .IsFixedLength();

            modelBuilder.Entity<AkimGerilim>()
                .Property(e => e.SargiNominalKademe)
                .IsFixedLength();

            modelBuilder.Entity<AkimGerilim>()
                .Property(e => e.SargiTeorikGerilimDegeri)
                .IsFixedLength();

            modelBuilder.Entity<AkimGerilim>()
                .Property(e => e.SargiGuc)
                .IsFixedLength();

            modelBuilder.Entity<AkimGerilim>()
                .Property(e => e.KademeDegisitiriciOnSecici)
                .IsFixedLength();

            modelBuilder.Entity<AkimGerilim>()
                .Property(e => e.FazIsimlendirmesi)
                .IsFixedLength();

            modelBuilder.Entity<AkimGerilim>()
                .Property(e => e.KademeSarimSayisi)
                .IsFixedLength();

            modelBuilder.Entity<AkimGerilim>()
                .Property(e => e.KademeDegistiriciTanimi)
                .IsFixedLength();

            modelBuilder.Entity<AkimGerilim>()
                .Property(e => e.KademeDegistiricKumandaUnitesi)
                .IsFixedLength();

            modelBuilder.Entity<ODAF>()
                .HasMany(e => e.ProjeGenel)
                .WithOptional(e => e.ODAF)
                .HasForeignKey(e => e.RootID);
        }
    }
}
