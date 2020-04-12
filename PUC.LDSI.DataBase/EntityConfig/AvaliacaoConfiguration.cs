﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class AvaliacaoConfiguration : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.Property(x => x.Disciplina).IsRequired();
            builder.Property(x => x.Disciplina).HasColumnType("varchar(100)");
            builder.Property(x => x.Materia).IsRequired();
            builder.Property(x => x.Materia).HasColumnType("varchar(100)");
            builder.Property(x => x.Descricao).IsRequired();
            builder.Property(x => x.Descricao).HasColumnType("varchar(250)");
            builder.HasOne(x => x.Professor).WithMany(x => x.Avaliacoes).HasForeignKey(x => x.ProfessorId);
  
            new EntityConfiguration();
        }
    }
}
