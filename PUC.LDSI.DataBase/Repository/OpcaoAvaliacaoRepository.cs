using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.Repository
{

    public class OpcaoAvaliacaoRepository : Repository<OpcaoAvaliacao>, IOpcaoAvaliacaoRepository
    {
        public OpcaoAvaliacaoRepository(AppDbContext context) : base(context) { }
    }

}
