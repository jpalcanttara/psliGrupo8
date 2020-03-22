﻿using System;
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
            var erros = new List<string>();

            if (AvaliacaoId == 0)
                erros.Add("A avaliação precisa ser informada!");

            if (TurmaId == 0)
                erros.Add("A turma precisa ser informada!");

            if (ValorProva == 0)
                erros.Add("O valor da prova precisa ser informada!");


            if (DataInicio == DateTime.MinValue)
                erros.Add("A data inicio precisa ser informada!");

            if (DataFim == DateTime.MinValue)
                erros.Add("A data fim precisa ser informada!");


            if (DataInicio > DataFim)
                erros.Add("A data fim invalida!");

            return erros.ToArray();
        }
    }
}
