using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class PublicacaoConfiguration : IEntityTypeConfiguration<Publicacao>
    {
        public void Configure(EntityTypeBuilder<Publicacao> builder)
        {
            builder.Property(x => x.AvaliacaoId).IsRequired();
            builder.Property(x => x.AvaliacaoId).HasColumnType("int");
            builder.Property(x => x.TurmaId).IsRequired();
            builder.Property(x => x.TurmaId).HasColumnType("int");
            builder.Property(x => x.DataInicio).IsRequired();
            builder.Property(x => x.DataInicio).HasColumnType("datetime");
            builder.Property(x => x.DataFim).IsRequired();
            builder.Property(x => x.DataFim).HasColumnType("datetime");
            builder.Property(x => x.ValorProva).IsRequired();
            builder.Property(x => x.ValorProva).HasColumnType("int");
            builder.HasOne(x => x.Avaliacao).WithMany(x => x.Publicacoes).HasForeignKey(x => x.AvaliacaoId);
            builder.HasOne(x => x.Turma).WithMany(x => x.Publicacoes).HasForeignKey(x => x.TurmaId);

            new EntityConfiguration();
        }
    }
}
