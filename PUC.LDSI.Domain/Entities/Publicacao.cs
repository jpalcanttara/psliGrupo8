using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Publicacao : Entity
    {
        public int AvaliacaoId { get; set; }
        public int TurmaId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int ValorProva { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Turma Turma { get; set; }

        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
