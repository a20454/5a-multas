using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class multas
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
        public agentes Agente{ get; set; }

        //FK para os condutores
        [ForeignKey("Condutor")]
        public int CondutoresFK { get; set; }
        public condutores Condutor { get; set; }

        //FK para as viaturas
        [ForeignKey("Viatura")]
        public int ViaturasFK { get; set; }
        public viaturas Viatura { get; set; }
    }
}