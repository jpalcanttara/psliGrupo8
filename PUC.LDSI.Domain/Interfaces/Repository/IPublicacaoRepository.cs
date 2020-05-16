using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.Domain.Interfaces.Repository
{
    public interface IPublicacaoRepository : IRepository<Publicacao> 
    {
        Task<List<Publicacao>> ListarPublicacoesDoProfessorAsync(int professorId);
        Task<List<Publicacao>> ListarPublicacoesDoAlunoAsync(int alunoId);
    }
}