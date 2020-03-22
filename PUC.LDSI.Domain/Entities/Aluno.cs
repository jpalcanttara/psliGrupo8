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
            var erros = new List<string>();
            if (TurmaId == 0)
                erros.Add("A turma precisa ser informada!");

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O nome precisa ser informada!");

            return erros.ToArray();
        }
    }
}
