using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class QuestaoAvaliacaoConfiguration : IEntityTypeConfiguration<QuestaoAvaliacao>
    {
        public void Configure(EntityTypeBuilder<QuestaoAvaliacao> builder)
        {
            builder.Property(x => x.avaliacaoId).IsRequired();
            builder.Property(x => x.avaliacaoId).HasColumnType("int");
            builder.Property(x => x.tipo).IsRequired();
            builder.Property(x => x.tipo).HasColumnType("int");
            builder.Property(x => x.enunciado).IsRequired();
            builder.Property(x => x.enunciado).HasColumnType("varchar(255)");
            builder.HasOne(x => x.avaliacao).WithMany(x => x.questoesAvaliacoes).HasForeignKey(x => x.avaliacaoId);

            new EntityConfiguration();
        }
    }
}
