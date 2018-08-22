using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMapp.Model;
using HMapp.DAO;
using System.Data;
using System.Data.SqlClient;


namespace HMapp.View
{
    public partial class frmCadPac : Form
    {
        Pacientes paciente = new Pacientes();
        DaoPacientes d_pac = new DaoPacientes();
        public frmCadPac()
        {
            InitializeComponent();
        }

        private void frmCadPac_Load(object sender, EventArgs e)
        {
            btnConsulta.Enabled = false;     
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.cpf = Convert.ToInt16(txtCPF.Text);
                paciente.rg = Convert.ToInt16(txtRG.Text);
                paciente.nome = txtNome.Text;
                paciente.sangue = Convert.ToChar(txtSangue.Text);
                paciente.sexo = Convert.ToChar(txtSexo.Text);
                paciente.coments = txtComents.Text;
                paciente.senha = txtSenha.Text;

                d_pac.Insert(paciente);
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
                paciente.cpf = Convert.ToInt16(txtCPF.Text);
                paciente = d_pac.BuscarPorCPF(paciente.cpf);

                txtCPF.Text = Convert.ToString(paciente.cpf);
                txtRG.Text = Convert.ToString(paciente.rg);
                txtNome.Text = paciente.nome;
                txtSangue.Text = Convert.ToString(paciente.sangue);
                txtSexo.Text = Convert.ToString(paciente.sexo);
                txtComents.Text = Convert.ToString(paciente.coments);

                btnConsulta.Enabled = true;
            }

            catch
            {
                MessageBox.Show("Algo de errado não está certo! Contate o ADM");
            }

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsulta registro = new frmConsulta();
            registro.Controls.SetChildIndex(txtCPF, this.paciente.cpf);
            registro.ShowDialog();
            this.Visible = true;
            registro.Controls.SetChildIndex(txtCPF, paciente.cpf);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
