using System;
using System.Collections.Generic;
using System.Text;

namespace NeohAutorizador.ApplicationCore.Entities
{
    public class Solicitacao
    {
        public int SolicitacaoId { get; set; }
        public string CnpjHospital { get; set; }
        public long ConvenioId { get; set; }
        public int NumeroGuia { get; set; }

    }
}
