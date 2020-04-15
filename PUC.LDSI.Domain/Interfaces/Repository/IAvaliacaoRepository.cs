using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Repository
{
    public interface IAvaliacaoRepository : IRepository<Avaliacao> {
    

        Task AdicionarAsync(Avaliacao obj);

        void Modificar(Avaliacao entity);
        Task<Avaliacao> ObterAsync(int id);
        
        IQueryable<Avaliacao> ObterTodos();
        void Excluir(int id);
        int SaveChanges();
    }
}
