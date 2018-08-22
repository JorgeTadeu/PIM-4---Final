using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMWebApp.Models
{
    public class Medicos
    {
        public int MedicosID { get; set; }
        public string nome { get; set; }
        public string espec { get; set; }
        public string coments { get; set; }
        public string senha { get; set; }
        public int ClinicasID { get; set; }
        public virtual Clinicas cli { get; set; }

    }
}
