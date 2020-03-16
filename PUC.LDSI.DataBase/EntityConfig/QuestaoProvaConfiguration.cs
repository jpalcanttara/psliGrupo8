using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class QuestaoProvaConfiguration : IEntityTypeConfiguration<QuestaoProva>
    {
        public void Configure(EntityTypeBuilder<QuestaoProva> builder)
        {
            builder.Property(x => x.questaoAvaliacaoId).IsRequired();
            builder.Property(x => x.questaoAvaliacaoId).HasColumnType("int");
            builder.Property(x => x.provaId).IsRequired();
            builder.Property(x => x.provaId).HasColumnType("int");
            builder.HasOne(x => x.questaoAvaliacao).WithMany(x => x.questoesProvas).HasForeignKey(x => x.questaoAvaliacaoId);
            builder.HasOne(x => x.prova).WithMany(x => x.questoesProvas).HasForeignKey(x => x.provaId);

            new EntityConfiguration();
        }
    }
}
