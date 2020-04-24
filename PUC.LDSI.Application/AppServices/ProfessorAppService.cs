using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.Domain.Entities;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Interfaces.Services;

namespace PUC.LDSI.Application.AppServices
{
    public class ProfessorAppService : IProfessorAppService
    {
        private readonly IProfessorService _professorService;
        public ProfessorAppService(IProfessorService professorService)
        {
            _professorService = professorService;
        }
        public async Task<DataResult<int>> IncluirProfessorAsync(string nome)
        {
            try
            {
                var retorno = await _professorService.IncluirProfessorAsync(nome);
                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
        }
    }
}