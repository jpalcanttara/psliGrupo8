using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Application.AppServices
{
    public class AvaliacaoAppService : IAvaliacaoAppService
    {
        private readonly IAvaliacaoService _avaliacaoService;


        public AvaliacaoAppService(IAvaliacaoService avaliacaoService)
        {
            _avaliacaoService = avaliacaoService;
        }

        public async Task<DataResult<int>> AdicionarAvaliacaoAsync(int professorId, string disciplina, string materia, string descricao)
        {
            try
            {
                var retorno = await _avaliacaoService.AdicionarAvaliacaoAsync(professorId, disciplina, materia, descricao);

                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex); 
            }
        }

        public Task<DataResult<int>> AdicionarOpcaoAvaliacaoAsync(int questaoId, string descricao, bool verdadeira)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<int>> AdicionarQuestaoAvaliacaoAsync(int avaliacaoId, int tipo, string enunciado)
        {
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> AlterarAvaliacaoAsync(int id, string disciplina, string materia, string descricao)
        {
            try
            {
                var retorno = await _avaliacaoService.AdicionarAvaliacaoAsync(id, disciplina, materia, descricao);

                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
        }

        public Task<DataResult<int>> AlterarOpcaoAvaliacaoAsync(int id, string descricao, bool verdadeira)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<int>> AlterarQuestaoAvaliacaoAsync(int id, int tipo, string enunciado)
        {
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> ExcluirAvaliacaoAsync(int id)
        {
            try
            {
                await _avaliacaoService.ExcluirAvaliacaoAsync(id);

                return new DataResult<int>(1);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
        }

        public Task<DataResult<int>> ExcluirOpcaoAvaliacaoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<int>> ExcluirQuestaoAvaliacaoAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
