using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMapp.Model
{
    public class Funcionarios
    {
        public int matricula { get; set; }
        public int rg { get; set; }
        public string nome { get; set; }
        public string cargo { get; set; }
        public string coments { get; set; }
        public string senha { get; set; }
        public Clinicas cli { get; set; }

    }
}
