
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Repository
{
    public interface IQuestaoProvaRepository : IRepository<QuestaoProva> {
        Task AdicionarAsync(QuestaoProva obj);
        void Modificar(QuestaoProva entity);
        Task<QuestaoProva> ObterAsync(int id);
        IQueryable<QuestaoProva> ObterTodos();
        void Excluir(int id);
        int SaveChanges();
    }

}
