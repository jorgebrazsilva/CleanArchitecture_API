using NeohAutorizador.ApplicationCore.Entities;
using NeohAutorizador.ApplicationCore.Interfaces.Repository;
using NeohAutorizador.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeohAutorizador.Infrastructure.Repository
{
    public class ExemploRepository : BaseRepository<Exemplo>, IExemploRepository
    {
        public ExemploRepository(NeohAutorizadorContext dbContext) : base(dbContext)
        {

        }
    }
}
