using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Turma : Entity
    {
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Publicacao> Publicacoes { get; set; }

        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
