using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HMWebApp.Models;

namespace HMWebApp.DAL
{
    public class IniciaBanco : System.Data.Entity.DropCreateDatabaseIfModelChanges<Banco>
    {
        protected override void Seed(Banco context)
        {
            var pacientes = new List<Pacientes>
            {
            new Pacientes{cpf=00300800531,rg=484884885,nome="Julia Martins",sangue='A', sexo ='F',coments="Alergica a Cenoura", senha="teste"},
            new Pacientes{cpf=00544478874,rg=254447778,nome="Marcos Metzker",sangue='O', sexo ='M',coments="Acima do Peso", senha="teste"},

            };

            pacientes.ForEach(s => context.pacientes.Add(s));
            context.SaveChanges();

            var medicos = new List<Medicos>
            {
            new Medicos{MedicosID=22222222,nome="Marlon Krepski",espec="Urologista", coments="Residente", senha="teste"},
            new Medicos{MedicosID=33333333,nome="Gustavo Magalhaes",espec="Ginecologista", coments="Cirugiao", senha="teste"},

            };
            medicos.ForEach(s => context.medicos.Add(s));
            context.SaveChanges();

            var consultas = new List<Consultas>
            {
            new Consultas{hr_inicio=DateTime.Parse("2016-06-01 12:57:08"),hr_fim=DateTime.Parse("2016-06-01 13:15:32"),coments="Paciente embrazado", MedicosID=1,PacientesID=1},
            new Consultas{hr_inicio=DateTime.Parse("2016-08-23 09:57:08"),hr_fim=DateTime.Parse("2016-06-01 10:15:32"),coments="Orelha seca", MedicosID=2,PacientesID=1},
            new Consultas{hr_inicio=DateTime.Parse("2015-08-23 15:57:08"),hr_fim=DateTime.Parse("2015-06-01 16:15:32"),coments="Dor no pescoço", MedicosID=1,PacientesID=2},
            new Consultas{hr_inicio=DateTime.Parse("2016-08-23 01:57:08"),hr_fim=DateTime.Parse("2016-01-01 02:15:32"),coments="Alcolismo Galopante", MedicosID=2,PacientesID=2},
            };

            consultas.ForEach(s => context.consultas.Add(s));
            context.SaveChanges();
        }

    }
}