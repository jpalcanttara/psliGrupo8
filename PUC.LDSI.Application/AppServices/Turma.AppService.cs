using PUC.LSDI.Application.Interfaces;
using PUC.LSDI.Domain.Entities;
using PUC.LSDI.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUC.LDSI.Application.AppServices
{
    public readonly ITurma _turmaService;

    public TurmaAppService(ITurmaService turmaService)
    {
        _turmaService = turmaService;
    }

    public async<DataResult<int>> AdicionarTurmaAsync(string descricao) 
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
            var retorno = await TurmaService.AlterarTurmaAsyncíid, descricao); return new DataResult<int>(retorno);
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
            await _turmaService.ExcluirAsync(id); return new DataResult<int>(l);
        }
        catch (Exception ex)
        {
            return new DataResult<int>(ex);
        }
    }

    public DataResult<List<Turma>> ListarTurmasQ
    {
        try
        {
            var retorno = _turmaService.ListarTurmas(); return new DataResult<List<Turma>>(retorno);
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
            var retorno = await _turmaService.ObterAsync(id); return new DataResult<Turma>(retorno);
        }
        catch (Exception ex)
        {
            return new DataResult<Turma>(ex);
        }
    }

}