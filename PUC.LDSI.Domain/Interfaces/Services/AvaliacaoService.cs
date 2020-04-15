using PUC.LDSI.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Services
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoService _AvaliacaoRepository;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository)
        {
            _AvaliacaoRepository = avaliacaoRepository;
        }

        Task<int> IAvaliacaoService.AdicionarAvaliacaoAsync(int professorId, string disciplina, string materia, string descricao)
        {
            throw new NotImplementedException();
        }

        Task<int> IAvaliacaoService.AdicionarOpcaoAvaliacaoAsync(int questaoId, string descricao, bool verdadeira)
        {
            throw new NotImplementedException();
        }

        Task<int> IAvaliacaoService.AdicionarQuestaoAvaliacaoAsync(int avaliacaoId, int tipo, string enunciado)
        {
            throw new NotImplementedException();
        }

        Task<int> IAvaliacaoService.AlterarAvaliacaoAsync(int id, string disciplina, string materia, string descricao)
        {
            throw new NotImplementedException();
        }

        Task<int> IAvaliacaoService.AlterarOpcaoAvaliacaoAsync(int id, string descricao, bool verdadeira)
        {
            throw new NotImplementedException();
        }

        Task<int> IAvaliacaoService.AlterarQuestaoAvaliacaoAsync(int id, int tipo, string enunciado)
        {
            throw new NotImplementedException();
        }

        Task<int> IAvaliacaoService.ExcluirAvaliacaoAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<int> IAvaliacaoService.ExcluirOpcaoAvaliacaoAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<int> IAvaliacaoService.ExcluirQuestaoAvaliacaoAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
