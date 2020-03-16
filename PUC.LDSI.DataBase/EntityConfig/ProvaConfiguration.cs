using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class ProvaConfiguration : IEntityTypeConfiguration<Prova>
    {
        public void Configure(EntityTypeBuilder<Prova> builder)
        {
            builder.Property(x => x.AvaliacaoId).IsRequired();
            builder.Property(x => x.AvaliacaoId).HasColumnType("int");
            builder.Property(x => x.AlunoId).IsRequired();
            builder.Property(x => x.AlunoId).HasColumnType("int");
            builder.Property(x => x.DataProva).IsRequired();
            builder.Property(x => x.DataProva).HasColumnType("datetime");
            builder.HasOne(x => x.Avaliacao).WithMany(x => x.Provas).HasForeignKey(x => x.AvaliacaoId);
            builder.HasOne(x => x.Aluno).WithMany(x => x.Provas).HasForeignKey(x => x.AlunoId);

            new EntityConfiguration();
        }
    }
}
