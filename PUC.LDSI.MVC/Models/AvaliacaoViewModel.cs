using PUC.LDSI.MVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PUC.LDSI.MVC.Models
{
    public class AvaliacaoViewModel
    {
        [Key]
        public int Id { get; set; }


        [DisplayName("Professor")]
        public string Professor { get; set; }

        [Required(ErrorMessage = "O campo Disciplina é obrigatório.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {0} caracteres.")]
        [DisplayName("Disciplina")]
        public string disciplina { get; set; }

        [Required(ErrorMessage = "O campo Matéria é obrigatório.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {0} caracteres.")]
        [DisplayName("Matéria")]
        public string materia { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {0} caracteres.")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public List<QuestaoAvaliacaoViewModel> Questoes { get; set; }
        public bool EhValida { get; set; }
    }
}
