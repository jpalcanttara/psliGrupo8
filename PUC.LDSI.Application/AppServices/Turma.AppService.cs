using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUC.LDSI.Application.AppServices
{
    public class TurmaAppService : ITurmaAppService
    {
        private readonly ITurmaAppService _turmaService;

        public TurmaAppService(ITurmaAppService turmaService)
        {
            _turmaService = turmaService;
        }

        public async Task<DataResult<int>> AdicionarTurmaAsync(string descricao)
        {
            try
            {
                var retorno = await _turmaService.AdicionarTurmaAsync(descricao);

                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
        }

        public async Task<DataResult<int>> AlterarTurmaAsync(int id, string descricao)
        {
            try
            {
                var retorno = await _turmaService.AlterarTurmaAsync(id, descricao);

                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
        }

        public async Task<DataResult<int>> ExcluirAsync(int id)
        {
            try
            {
                var retorno = await _turmaService.ExcluirAsync(id);

                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
        }

        public DataResult<List<Turma>> ListarTurmas()
        {
            try
            {
                var retorno = _turmaService.ListarTurmas();

                return new DataResult<List<Turma>>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<List<Turma>>(ex);
            }
        }

        public async Task<DataResult<Turma>> ObterAsync(int id)
        {
            try
            {
                var retorno = await _turmaService.ObterAsync(id);

                return new DataResult<Turma>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<Turma>(ex);
            }
        }
    }
}