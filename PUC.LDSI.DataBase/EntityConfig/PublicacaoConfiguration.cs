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
            builder.Property(x => x.avalicaoId).IsRequired();
            builder.Property(x => x.avalicaoId).HasColumnType("int");
            builder.Property(x => x.turmaId).IsRequired();
            builder.Property(x => x.turmaId).HasColumnType("int");
            builder.Property(x => x.dataInicio).IsRequired();
            builder.Property(x => x.dataInicio).HasColumnType("datetime");
            builder.Property(x => x.dataFim).IsRequired();
            builder.Property(x => x.dataFim).HasColumnType("datetime");
            builder.Property(x => x.valorProva).IsRequired();
            builder.Property(x => x.valorProva).HasColumnType("int");
            builder.HasOne(x => x.avaliacao).WithMany(x => x.publicacoes).HasForeignKey(x => x.avalicaoId);
            builder.HasOne(x => x.turma).WithMany(x => x.publicacoes).HasForeignKey(x => x.turmaId);

            new EntityConfiguration();
        }
    }
}
