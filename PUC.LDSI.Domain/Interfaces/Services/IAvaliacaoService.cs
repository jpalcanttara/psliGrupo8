using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Services
{
    public interface IAvaliacaoService
    {
        //Retorna o Id da avaliação criada
        Task<int> AdicionarAvaliacaoAsync(int professorId, string disciplina, string materia, string descricao);
        //Retorna o Id da questão criada
        Task<int> AdicionarQuestaoAvaliacaoAsync(int avaliacaoId, int tipo, string enunciado);
        //Retorna o Id da opção criada
        Task<int> AdicionarOpcaoAvaliacaoAsync(int questaoId, string descricao, bool verdadeira);

        //Retorna o Id da avaliação alterada
        Task<int> AlterarAvaliacaoAsync(int id, string disciplina, string materia, string descricao);
        //Retorna o Id da questão alterada
        Task<int> AlterarQuestaoAvaliacaoAsync(int id, int tipo, string enunciado);
        //Retorna o Id da opção alterada
        Task<int> AlterarOpcaoAvaliacaoAsync(int id, string descricao, bool verdadeira);

        Task<int> ExcluirAvaliacaoAsync(int id);
        //Retorna o Id da avaliação cuja questão pertencia
        Task<int> ExcluirQuestaoAvaliacaoAsync(int id);
        //Retorna o Id da questão cuja opção pertencia
        Task<int> ExcluirOpcaoAvaliacaoAsync(int id);
    }
}
