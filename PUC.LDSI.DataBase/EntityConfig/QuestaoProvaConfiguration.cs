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
            builder.Property(x => x.QuestionId).IsRequired();
            builder.Property(x => x.QuestionId).HasColumnType("int");
            builder.Property(x => x.ProvaId).IsRequired();
            builder.Property(x => x.ProvaId).HasColumnType("int");
            builder.HasOne(x => x.Questao).WithMany(x => x.QuestoesProva).HasForeignKey(x => x.QuestionId);
            builder.HasOne(x => x.Prova).WithMany(x => x.QuestoesProva).HasForeignKey(x => x.ProvaId);

            new EntityConfiguration();
        }
    }
}
