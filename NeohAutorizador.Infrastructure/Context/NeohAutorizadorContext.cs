using Microsoft.EntityFrameworkCore;
using NeohAutorizador.ApplicationCore.Entities;
using NeohAutorizador.Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeohAutorizador.Infrastructure.Context
{
    public class NeohAutorizadorContext : DbContext
    {
        public NeohAutorizadorContext() { }
        public NeohAutorizadorContext(DbContextOptions<NeohAutorizadorContext> opcoes) : base(opcoes) { }

        public DbSet<Exemplo> Exemplo { get; set; }
        public DbSet<ExemploItem> ExemploItem { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration.Remove<PluralizingTableNameConvention>(); //plularização de objetos
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //deleção em cascata de filho
            modelBuilder.ApplyConfiguration(new ExemploConfig());
            modelBuilder.ApplyConfiguration(new ExemploItemConfig());
        }
    }
}
