using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Avaliacao : Entity
    {
        public int ProfessorId { get; set; }
        public string Disciplina { get; set; }
        public string Materia { get; set; }
        public string Descricao { get; set; }
        public Professor Professor { get; set; }
        public List<Publicacao> Publicacoes { get; set; }
        public List<Prova> Provas { get; set; }
        public List<Questao> Questoes { get; set; }

        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
