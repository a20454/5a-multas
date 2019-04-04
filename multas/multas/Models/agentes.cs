using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class agentes
    {
        //id, nome, esquadra, foto
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Esquadra { get; set; }

        public string Fotografia { get; set; }

        //identifica as multas passadas pelo agente
        public ICollection<multas> ListaMultas { get; set; }
    }
}