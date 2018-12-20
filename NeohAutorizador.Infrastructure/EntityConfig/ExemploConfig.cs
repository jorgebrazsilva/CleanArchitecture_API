using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeohAutorizador.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeohAutorizador.Infrastructure.EntityConfig
{
    public class ExemploConfig : IEntityTypeConfiguration<Exemplo>
    {
        public void Configure(EntityTypeBuilder<Exemplo> builder)
        {
            builder.ToTable("EXEMPLOS");
            builder.HasKey(c => c.ExemploId).HasName("ID_EXEMPLO");
            builder.Property(c => c.ExemploId).HasColumnName("ID_EXEMPLO").ValueGeneratedOnAdd();
            builder.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(200);           
        }
    }
}
