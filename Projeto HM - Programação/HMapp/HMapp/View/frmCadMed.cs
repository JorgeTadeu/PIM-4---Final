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
    public partial class frmCadMed : Form
    {
        Medicos medico = new Medicos();
        DaoMedicos d_med = new DaoMedicos();
        public frmCadMed()
        {
            InitializeComponent();
        }

        
       
        private void frmCadMed_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                medico.crm = Convert.ToInt16(txtCRM.Text);
                medico.nome = txtNome.Text;
                medico.espec = txtEspec.Text;
                medico.coments = txtComents.Text;
                medico.senha = txtSenha.Text;

                d_med.Insert(medico);
            }
            catch
            {
                MessageBox.Show("Algo de errado não está certo! Contate o ADM");
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                medico.crm = Convert.ToInt16(txtCRM.Text);
                medico = d_med.BuscarPorCRM(medico.crm);

                txtCRM.Text = Convert.ToString(medico.crm);
                txtNome.Text = medico.nome;
                txtEspec.Text = Convert.ToString(medico.espec);
                txtComents.Text = Convert.ToString(medico.coments);
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
