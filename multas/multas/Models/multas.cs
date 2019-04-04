﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class Multas
    {
        //id, data, valor, infracao, fK viatura, fk agente,fk condutor
        public int ID { get; set; }

        public string Infracao { get; set; }

        public string LocalDaMulta { get; set; }

        public decimal ValorMulta { get; set; }

        public DateTime DataDaMulta { get; set; }

        //criar chaves forasteiras

        //FK para os agentes
        [ForeignKey("Agente")]
        public int AgenteFK { get; set; }
        public Agentes Agente{ get; set; }

        //FK para os condutores
        [ForeignKey("Condutor")]
        public int CondutorFK { get; set; }
        public Condutores Condutor { get; set; }

        //FK para as viaturas
        [ForeignKey("Viatura")]
        public int ViaturaFK { get; set; }
        public Viaturas Viatura { get; set; }
    }
}