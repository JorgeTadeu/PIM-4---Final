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
using HMapp.Model;

namespace HMapp.View
{
    public partial class frmConsulta : Form
    {
        Consultas consulta = new Consultas();
        DaoConsultas d_cons = new DaoConsultas();
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            this.txtHraInicio.Value = DateTime.Now;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                consulta.id = Convert.ToInt16(txtID.Text);
                consulta.hr_inicio = Convert.ToDateTime(txtHraInicio);
                consulta.hr_fim = DateTime.Now;
                consulta.coments = txtComents.Text;
                consulta.pac.cpf = Convert.ToInt16(txtCPF.Text);

                d_cons.Insert(consulta);
            }

            catch
            {
                MessageBox.Show("Algo de errado não está certo! Contate o ADM");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
