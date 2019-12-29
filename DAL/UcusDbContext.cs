using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UcusDbContext: DbContext
    {
        public UcusDbContext() : base("cstr")
        {

        }
        public DbSet<Havayolu> Havayollari { get; set; }
        public DbSet<Ucak> HavayoluEnvanterleri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent Api
            modelBuilder.Entity<Havayolu>().ToTable("tblHavayollari");
            modelBuilder.Entity<Havayolu>().Property(h => h.Id_Havayolu).HasMaxLength(10).IsRequired().HasColumnType("nvarchar");
            modelBuilder.Entity<Havayolu>().Property(h => h.Havayolu_Adi).HasMaxLength(30).IsRequired().HasColumnType("nvarchar");
            //modelBuilder.Entity<Havayolu>().Property(h => h.Id_Ucak).HasMaxLength(10).IsRequired().HasColumnType("nvarchar");

            modelBuilder.Entity<Ucak>().ToTable("tblHavayoluEnvanter");
            modelBuilder.Entity<Ucak>().Property(u => u.Id_Havayolu).HasMaxLength(10).IsRequired().HasColumnType("nvarchar");
            modelBuilder.Entity<Ucak>().Property(u => u.Id_Ucak).HasMaxLength(10).IsRequired().HasColumnType("nvarchar");
            modelBuilder.Entity<Ucak>().Property(u => u.Adet).IsRequired().HasColumnType("int");

            //modelBuilder.Entity<Havayolu>()
            //    .HasMany<Ucak>(s => s.Ucak)
            //    .WithMany(c => c.Havayolu)
            //    .Map(cs =>
            //    {
            //        cs.MapLeftKey("Id_Havayolu");
            //        cs.MapRightKey("Id_Ucak");
            //        cs.ToTable("tblHavayollari");
            //    });

        }
    }
}
