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
            builder.Property(x => x.avaliacaoId).IsRequired();
            builder.Property(x => x.avaliacaoId).HasColumnType("int");
            builder.Property(x => x.alunoId).IsRequired();
            builder.Property(x => x.alunoId).HasColumnType("int");
            builder.Property(x => x.dataProva).IsRequired();
            builder.Property(x => x.dataProva).HasColumnType("datetime");
            builder.HasOne(x => x.avaliacao).WithMany(x => x.provas).HasForeignKey(x => x.avaliacaoId);
            builder.HasOne(x => x.aluno).WithMany(x => x.provas).HasForeignKey(x => x.alunoId);

            new EntityConfiguration();
        }
    }
}
