namespace DSS.DA
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tbCHIPHI> tbCHIPHIs { get; set; }
        public virtual DbSet<tbCHITIETTHIETKE> tbCHITIETTHIETKEs { get; set; }
        public virtual DbSet<tbDANHMUCTHIETKE> tbDANHMUCTHIETKEs { get; set; }
        public virtual DbSet<tbHINHANHTHIETKE> tbHINHANHTHIETKEs { get; set; }
        public virtual DbSet<tbKHACHHANG> tbKHACHHANGs { get; set; }
        public virtual DbSet<tbKIENTRUCSU> tbKIENTRUCSUs { get; set; }
        public virtual DbSet<tbKIENTRUCTHIETKE> tbKIENTRUCTHIETKEs { get; set; }
        public virtual DbSet<tbLICHHEN> tbLICHHENs { get; set; }
        public virtual DbSet<tbLUACHONTHIETKE> tbLUACHONTHIETKEs { get; set; }
        public virtual DbSet<tbTHIETKE> tbTHIETKEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbCHIPHI>()
                .Property(e => e.soicat)
                .IsFixedLength();

            modelBuilder.Entity<tbCHITIETTHIETKE>()
                .Property(e => e.santruoc_sau)
                .IsFixedLength();

            modelBuilder.Entity<tbDANHMUCTHIETKE>()
                .HasMany(e => e.tbTHIETKEs)
                .WithOptional(e => e.tbDANHMUCTHIETKE)
                .HasForeignKey(e => e.id_danhmuc);

            modelBuilder.Entity<tbKHACHHANG>()
                .Property(e => e.sdt)
                .IsFixedLength();

            modelBuilder.Entity<tbKHACHHANG>()
                .HasMany(e => e.tbLICHHENs)
                .WithOptional(e => e.tbKHACHHANG)
                .HasForeignKey(e => e.id_khachhang);

            modelBuilder.Entity<tbKHACHHANG>()
                .HasMany(e => e.tbLUACHONTHIETKEs)
                .WithRequired(e => e.tbKHACHHANG)
                .HasForeignKey(e => e.id_khachhang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbKIENTRUCSU>()
                .Property(e => e.lienhe)
                .IsFixedLength();

            modelBuilder.Entity<tbKIENTRUCSU>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<tbKIENTRUCSU>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<tbKIENTRUCSU>()
                .HasMany(e => e.tbKIENTRUCTHIETKEs)
                .WithRequired(e => e.tbKIENTRUCSU)
                .HasForeignKey(e => e.id_kientrucsu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbKIENTRUCSU>()
                .HasMany(e => e.tbLUACHONTHIETKEs)
                .WithOptional(e => e.tbKIENTRUCSU)
                .HasForeignKey(e => e.id_kientrucsu);

            modelBuilder.Entity<tbLICHHEN>()
                .Property(e => e.gio)
                .IsFixedLength();

            modelBuilder.Entity<tbTHIETKE>()
                .HasMany(e => e.tbCHIPHIs)
                .WithOptional(e => e.tbTHIETKE)
                .HasForeignKey(e => e.id_thietke);

            modelBuilder.Entity<tbTHIETKE>()
                .HasMany(e => e.tbCHITIETTHIETKEs)
                .WithOptional(e => e.tbTHIETKE)
                .HasForeignKey(e => e.id_thietke);

            modelBuilder.Entity<tbTHIETKE>()
                .HasMany(e => e.tbHINHANHTHIETKEs)
                .WithOptional(e => e.tbTHIETKE)
                .HasForeignKey(e => e.id_thietke);

            modelBuilder.Entity<tbTHIETKE>()
                .HasMany(e => e.tbKIENTRUCTHIETKEs)
                .WithRequired(e => e.tbTHIETKE)
                .HasForeignKey(e => e.id_thietke)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbTHIETKE>()
                .HasMany(e => e.tbLUACHONTHIETKEs)
                .WithRequired(e => e.tbTHIETKE)
                .HasForeignKey(e => e.id_thietke)
                .WillCascadeOnDelete(false);
        }
    }
}
