using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMWebApp.Models
{
    public class Funcionarios
    {
        public int FuncionariosID { get; set; }
        public int rg { get; set; }
        public string nome { get; set; }
        public string cargo { get; set; }
        public string coments { get; set; }
        public string senha { get; set; }
        public int ClinicasID { get; set; }
        public Clinicas cli { get; set; }

    }
}
