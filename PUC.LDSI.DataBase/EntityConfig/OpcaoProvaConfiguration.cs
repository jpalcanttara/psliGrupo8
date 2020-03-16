using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class OpcaoProvaConfiguration : IEntityTypeConfiguration<OpcaoProva>
    {
        public void Configure(EntityTypeBuilder<OpcaoProva> builder)
        {
            builder.Property(x => x.questaoProvaId).IsRequired().HasColumnType("int");
            builder.Property(x => x.opcaoAvaliacaoId).IsRequired().HasColumnType("int");
            builder.HasOne(x => x.questaoProva).WithMany(x => x.opcoesProvas).HasForeignKey(x => x.questaoProvaId);
            builder.HasOne(x => x.opcaoAvaliacao).WithMany(x => x.opcoesProvas).HasForeignKey(x => x.opcaoAvaliacaoId);

            new EntityConfiguration();
        }
    }
}
