using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMWebApp.Models
{
    public class Clinicas
    {
        public int ClinicasID { get; set; }
        public string cnpj { get; set; }
        public string nome { get; set; }
        public virtual ICollection<Funcionarios> funcionarios { get; set; }
        public virtual ICollection<Medicos> medicos { get; set; }
    }
}
