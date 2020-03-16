using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class OpcaoAvaliacaoConfiguration : IEntityTypeConfiguration<OpcaoAvaliacao>
    {
        public void Configure(EntityTypeBuilder<OpcaoAvaliacao> builder)
        {
            builder.Property(x => x.Descricao).IsRequired();
            builder.Property(x => x.Descricao).HasColumnType("varchar(250)");
            builder.HasOne(x => x.Questao).WithMany(x => x.OpcoesAvaliacao).HasForeignKey(x => x.QuestaoId);

            new EntityConfiguration();
        }
    }
}
