
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace PUC.LDSI.MVC.Models
{
    public class QuestaoAvaliacaoViewModel
    {

        [Key]
        public int Id { get; set; }
        public int AvaliacaoId { get; set; }
        int cont = 0;

        [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
        [DisplayName("Tipo")]
        public int Tipo { get; set; }//1 = Múltipla escolha e 2 = Verdadeiro ou Falso

        [Required(ErrorMessage = "O campo Enunciado é obrigatório.")]
        [MaxLength(225, ErrorMessage = "Informe no máximo {0} caracteres.")]
        public string Enunciado { get; set; }

        public AvaliacaoViewModel Avaliacao { get; set; }
        public List<OpcaoAvaliacaoViewModel> Opcoes { get; set; }
        public string Erro
        {
            get
            {
                if (Opcoes == null || Opcoes.Count < 4)
                    return "A questão deve ter pelo menos 4 (quatro) opções.";
                if (Tipo == 1)
                {
                    for (int i = 0; i < Opcoes.Count; i++)
                    {
                        if (Opcoes[i].Verdadeira)
                            cont++;
                    }
                }
                if (cont == 0)
                    return "A questão deve ter pelo menos 1 (uma) opção verdadeira.";
                return "";
            }

        }


    }
}
