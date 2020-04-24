using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Interfaces.Services;
using PUC.LDSI.Domain.Interfaces.Repository;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Exception;
using System.Linq;

namespace PUC.LDSI.Domain.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;
        public ProfessorService(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }
        public async Task<int> IncluirProfessorAsync(string nome)
        {
            var professor = new Professor() { Nome = nome };
            var erros = professor.Validate();

            if (erros.Length == 0)
            {
                await _professorRepository.AdicionarAsync(professor);
                _professorRepository.SaveChanges();
                return professor.Id;
            }
            else throw new DomainException(erros);
        }
    }
}
