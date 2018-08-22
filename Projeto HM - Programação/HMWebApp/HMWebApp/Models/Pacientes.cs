using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMWebApp.Models
{
    public class Pacientes
    {
        public int ID { get; set; }
        public int cpf { get; set; }
        public int rg { get; set; }
        public string nome { get; set; }
        public char sangue { get; set; }
        public char sexo { get; set; }
        public string coments { get; set; }
        public string senha { get; set; }
        public virtual ICollection<Consultas> consultas { get; set; }


    }
}
