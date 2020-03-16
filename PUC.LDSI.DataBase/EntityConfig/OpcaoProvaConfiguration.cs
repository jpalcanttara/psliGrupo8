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
            builder.Property(x => x.QuestaoProvaId).IsRequired().HasColumnType("int");
            builder.Property(x => x.OpcaoAvaliacaoId).IsRequired().HasColumnType("int");
            builder.HasOne(x => x.QuestaoProva).WithMany(x => x.OpcoesProva).HasForeignKey(x => x.QuestaoProvaId);
            builder.HasOne(x => x.OpcaoAvaliacao).WithMany(x => x.OpcoesProva).HasForeignKey(x => x.OpcaoAvaliacaoId);

            new EntityConfiguration();
        }
    }
}
