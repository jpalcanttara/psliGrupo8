using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.IRepository;
using PUC.LDSI.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.Repository
{
    public class QuestaoProvaRepository : Repository<QuestaoProva>, IQuestaoProvaRepository
    {
        public QuestaoProvaRepository(AppDbContext context) : base(context) { }
    }
}
