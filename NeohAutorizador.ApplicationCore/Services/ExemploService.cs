using NeohAutorizador.ApplicationCore.Entities;
using NeohAutorizador.ApplicationCore.Interfaces.Repository;
using NeohAutorizador.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeohAutorizador.ApplicationCore.Services
{
    public class ExemploService : BaseService<Exemplo>, IExemploService
    {
        private readonly IExemploRepository _exemploRepository;
        public ExemploService(IExemploRepository exemploRepository) : base(exemploRepository)
        {
            _exemploRepository = exemploRepository;
        }
    }
}
