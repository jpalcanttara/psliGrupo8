using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.Property(x => x.nome).IsRequired();
            builder.Property(x => x.nome).HasColumnType("varchar(100)");
            builder.HasOne(x => x.turma).WithMany(x => x.alunos).HasForeignKey(x => x.turmaId);
            new EntityConfiguration();
        }
    }
}
