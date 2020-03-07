using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class OpcaoProva : Entity
    {
        public int OpcaoAvaliacaoId { get; set; }
        public int QuestaoProvaId { get; set; }
        public bool Resposta { get; set; }
        public OpcaoAvaliacao OpcaoAvaliacao { get; set; }
        public QuestaoProva QuestaoProva { get; set; }

        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
