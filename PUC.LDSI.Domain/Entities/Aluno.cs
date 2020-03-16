using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Aluno : Entity
    {
        public string Nome { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public List<Prova> Provas { get; set; }

        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
