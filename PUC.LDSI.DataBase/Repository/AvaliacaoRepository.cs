﻿using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.Repository
{
    public class AvaliacaoRepository : Repository<Avaliacao>, IAvaliacaoRepository
    {
        private readonly AppDbContext _context;
        public AvaliacaoRepository(AppDbContext context) : base(context) {
            _context = context;
        }
    }
     
}