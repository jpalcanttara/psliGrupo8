using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Entities;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Services
{
    public interface IProfessorService
    {
        Task<int> IncluirProfessorAsync(string nome);
    }
}
