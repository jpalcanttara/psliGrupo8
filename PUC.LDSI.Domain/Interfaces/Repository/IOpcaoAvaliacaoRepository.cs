using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.IRepository
{
    public interface IOpcaoAvaliacaoRepository : IRepository<OpcaoAvaliacao> {
        Task AdicionarAsync(OpcaoAvaliacao obj);
        void Modificar(OpcaoAvaliacao entity);
        Task<OpcaoAvaliacao> ObterAsync(int id);
        IQueryable<OpcaoAvaliacao> ObterTodos();
        void Excluir(int id);
        int SaveChanges();
    }
}
