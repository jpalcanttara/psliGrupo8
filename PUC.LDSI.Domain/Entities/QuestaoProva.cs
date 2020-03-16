using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class QuestaoProva : Entity
    {
        public int QuestionId { get; set; }
        public int ProvaId { get; set; }
        public decimal Nota { get; set; }
        public Questao Questao { get; set; }
        public Prova Prova { get; set; }
        public List<OpcaoProva> OpcoesProva { get; set; }

        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
