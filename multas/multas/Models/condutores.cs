﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class Condutores
    {
        // 
        public int ID { get; set; }

        public string Nome { get; set; }

        public string BI { get; set; }

        public string Telemovel { get; set; }

        public DateTime DataNascimento { get; set; }

        public string NumCartaConducao { get; set; }

        public string LocalEmissao { get; set; }

        public DateTime DataValidadeCarta { get; set; }

        //lista das multas associadas ao condutor
        public ICollection<Multas> ListaMultas { get; set; }
    }
}