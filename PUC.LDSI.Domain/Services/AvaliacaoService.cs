using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Exception;
using PUC.LDSI.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Services
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        private readonly IOpcaoAvaliacaoRepository _opcaoavaliacaoRepository;
        private readonly IQuestaoProvaRepository _questaoavaliacaoRepository;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
        }
        
        public AvaliacaoService(IOpcaoAvaliacaoRepository opcaoavaliacaoRepository)
        {
            _opcaoavaliacaoRepository = opcaoavaliacaoRepository;
        }
        public AvaliacaoService(IQuestaoProvaRepository questaoavaliacaoRepository)
        {
            _questaoavaliacaoRepository = questaoavaliacaoRepository;
        }

        public Task<int> AdicionarAvaliacaoAsync(int professorId, string disciplina, string materia, string descricao)
        {
            throw new NotImplementedException();
        }

        public Task<int> AdicionarOpcaoAvaliacaoAsync(int questaoId, string descricao, bool verdadeira)
        {
            throw new NotImplementedException();
        }

        public Task<int> AdicionarQuestaoAvaliacaoAsync(int avaliacaoId, int tipo, string enunciado)
        {
            throw new NotImplementedException();
        }

        public Task<int> AlterarAvaliacaoAsync(int id, string disciplina, string materia, string descricao)
        {
            throw new NotImplementedException();
        }

        public Task<int> AlterarOpcaoAvaliacaoAsync(int id, string descricao, bool verdadeira)
        {
            throw new NotImplementedException();
        }

        public Task<int> AlterarQuestaoAvaliacaoAsync(int id, int tipo, string enunciado)
        {
            throw new NotImplementedException();
        }

        public async Task<int> ExcluirAvaliacaoAsync(int id)
        {
            var avaliacao = await _avaliacaoRepository.ObterAsync(id);
            if (avaliacao.Publicacoes?.Count > 0)
                throw new DomainException("Não é possível excluir uma avaliação que já foi publicada ou realizada!");
            _avaliacaoRepository.Excluir(id);
            _avaliacaoRepository.SaveChanges();
            return 1;
        }

        public async Task<int> ExcluirOpcaoAvaliacaoAsync(int id)
        {
            var opcaoavaliacao = await _opcaoavaliacaoRepository.ObterAsync(id);
            if (opcaoavaliacao.OpcoesProva?.Count > 0)
                throw new DomainException("Não é possível excluir a opção de uma avaliação que já foi realizada!");
            _opcaoavaliacaoRepository.Excluir(id);
            _opcaoavaliacaoRepository.SaveChanges();
            return 1;
        }

        public async Task<int> ExcluirQuestaoAvaliacaoAsync(int id)
        {

            var questaoavaliacao = await _questaoavaliacaoRepository.ObterAsync(id);
            if (questaoavaliacao.Questao != null) 
                throw new DomainException("NNão é possível excluir a questão de uma avaliação que já foi realizada!");
            _questaoavaliacaoRepository.Excluir(id);
            _questaoavaliacaoRepository.SaveChanges();
            return 1;
        }
    }
}