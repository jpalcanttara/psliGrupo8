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
            builder.Property(x => x.descricao).IsRequired();
            builder.Property(x => x.descricao).HasColumnType("varchar(250)");
            builder.HasOne(x => x.questaoAvaliacao).WithMany(x => x.opcoesAvaliacoes).HasForeignKey(x => x.questaoAvaliacaoId);

            new EntityConfiguration();
        }
    }
}
