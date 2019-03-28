using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class MultasDb : DbContext
    {

        public MultasDb() : base("MultasConnectionString") { }

        //especificar as tableas da DB
        public DbSet<agentes> Agentes { get; set; }
        public DbSet<viaturas> Carros { get; set; }
        public DbSet<condutores> Condutores { get; set; }
        public DbSet<multas> Multas { get; set; }
    }
}