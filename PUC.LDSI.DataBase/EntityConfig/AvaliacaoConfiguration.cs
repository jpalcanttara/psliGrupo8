using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class AvaliacaoConfiguration : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.Property(x => x.disciplina).IsRequired();
            builder.Property(x => x.disciplina).HasColumnType("varchar(100)");
            builder.Property(x => x.materia).IsRequired();
            builder.Property(x => x.materia).HasColumnType("varchar(100)");
            builder.Property(x => x.descricao).IsRequired();
            builder.Property(x => x.descricao).HasColumnType("varchar(250)");
            builder.HasOne(x => x.professor).WithMany(x => x.avaliacoes).HasForeignKey(x => x.professorId);
  
            new EntityConfiguration();
        }
    }
}
