using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class MultasDb : DbContext
    {

        public MultasDb() : base("MultasDBConnectionString") { }

        // vamos colocar, aqui, as instruções relativas às tabelas do 'negócio'
        // descrever os nomes das tabelas na Base de Dados
        public virtual DbSet<multas> Multas { get; set; } // tabela Multas
        public virtual DbSet<condutores> Condutores { get; set; } // tabela Condutores
        public virtual DbSet<agentes> Agentes { get; set; } // tabela Agentes
        public virtual DbSet<viaturas> Viaturas { get; set; } // tabela Viaturas


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}