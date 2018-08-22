using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMapp.Model
{
    public class Consultas
    {
        public int id { get; set; }
        public DateTime hr_inicio { get; set; }
        public DateTime hr_fim { get; set; }
        public string coments { get; set; }
        public Pacientes pac { get; set; }
        public Medicos med { get; set; }
    }
}
