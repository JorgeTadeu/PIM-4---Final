using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMapp.DAO;
using System.Data;
using System.Data.SqlClient;
using HMapp.Model;


namespace HMapp.View
{
    public partial class frmHistorico : Form
    {
        Pacientes paciente = new Pacientes();
        Consultas consulta = new Consultas();
        DaoPacientes d_pac = new DaoPacientes();
        DaoConsultas d_cons= new DaoConsultas();

        public frmHistorico()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = this.txtCPF.Text;

                dgvPacientes.DataSource = d_pac.dt_pac(Convert.ToInt16(cpf));

                dgvConsultas.DataSource = d_cons.dt_cons(Convert.ToInt16(cpf));
            }
            catch
            {
                MessageBox.Show("Algo de errado não está certo! Contate o ADM");
            }
        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
