using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.Repository
{
    public class QuestaoProvaRepository : Repository<QuestaoProva>, IQuestaoProvaRepository
    {
        private readonly AppDbContext _context;
        public QuestaoProvaRepository(AppDbContext context) : base(context) {
            _context = context;
        }
    }
}
