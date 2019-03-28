using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class multas
    {
        //id, data, valor, infracao, fK viatura, fk agente,fk condutor
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Infrcao { get; set; }

    }
}