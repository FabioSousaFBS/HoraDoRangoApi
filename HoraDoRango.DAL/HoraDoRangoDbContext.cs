namespace HoraDoRango.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using HoraDoRango.Entities;

    public partial class HoraDoRangoDbContext : DbContext
    {
        public HoraDoRangoDbContext()
            : base("name=HoraDoRangoDbContext")
        {
        }

        //public virtual DbSet<Historico> Historico { get; set; }
        public virtual DbSet<PESSOA> Pessoa { get; set; }
        //public virtual DbSet<Restaurante> Restaurante { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
