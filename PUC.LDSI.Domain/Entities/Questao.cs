using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Questao : Entity
    {
        public int AvaliacaoId { get; set; }
        public int Tipo { get; set; }
        public string Enunciado { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public List<QuestaoProva> QuestoesProva { get; set; }
        public List<OpcaoAvaliacao> OpcoesAvaliacao { get; set; }

        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
