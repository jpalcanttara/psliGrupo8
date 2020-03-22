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
            var erros = new List<string>();

            if (OpcaoAvaliacaoId == 0)
                erros.Add("A Opção precisa ser informada!"); //correção

            if (QuestaoProvaId == 0)
                erros.Add("A questão precisa ser informada!"); //correção

            return erros.ToArray();
        }
    }
}
