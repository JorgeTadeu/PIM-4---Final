using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMapp.Model
{
    public class Medicos
    {
        public int crm { get; set; }
        public string nome { get; set; }
        public string espec { get; set; }
        public string coments { get; set; }
        public string senha { get; set; }
        public Clinicas cli { get; set; }

    }
}
