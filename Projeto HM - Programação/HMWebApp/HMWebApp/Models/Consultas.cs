using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMWebApp.Models
{
    public class Consultas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConsultasID { get; set; }
        public DateTime hr_inicio { get; set; }
        public DateTime hr_fim { get; set; }
        public string coments { get; set; }
        public int MedicosID { get; set; }
        public int PacientesID { get; set; }
        public virtual Pacientes pac { get; set; }
        public virtual Medicos med { get; set; }
    }
}
