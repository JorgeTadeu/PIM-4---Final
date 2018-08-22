using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMWebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HMWebApp.DAL
{
    public class Banco : DbContext
    {

        public Banco() : base("Banco")
        {
        }

        public DbSet<Clinicas> clinicas { get; set; }
        public DbSet<Consultas> consultas { get; set; }
        public DbSet<Funcionarios> funcionarios { get; set; }
        public DbSet<Medicos> medicos { get; set; }
        public DbSet<Pacientes> pacientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}