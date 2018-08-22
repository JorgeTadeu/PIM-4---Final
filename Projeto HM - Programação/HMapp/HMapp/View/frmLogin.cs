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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLoginMed_Click(object sender, EventArgs e)
        {
            Medicos med = new Medicos();
            DaoMedicos d_med = new DaoMedicos();
            try
            {
                med = d_med.BuscarPorCRM(Convert.ToInt16(txtLogin.Text));

                if (txtLogin.Text == Convert.ToString(med.crm) && txtSenha.Text == med.senha)

                //if (txtLogin.Text == "adm" && txtSenha.Text == "adm")
                {
                    MessageBox.Show("Seja bem vindo!");
                    this.Visible = false;
                    View.frmMenu menu = new View.frmMenu();
                    menu.logado = 1;
                    menu.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto!");
                }
            }
            catch
            {
                MessageBox.Show("Algo de errado não está certo! Contate o ADM");
            }
        }

        private void btnLoginFun_Click(object sender, EventArgs e)
        {
            Funcionarios fun = new Funcionarios();
            DaoFuncionarios d_fun = new DaoFuncionarios();
            try
            {
                fun = d_fun.BuscarPorMatricula(Convert.ToInt16(txtLogin.Text));

                if (txtLogin.Text == Convert.ToString(fun.matricula) && txtSenha.Text == fun.senha)
                {
                    MessageBox.Show("Seja bem vindo!");
                    this.Visible = false;
                    View.frmMenu menu = new View.frmMenu();
                    menu.logado = 2;
                    menu.ShowDialog();
                    this.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Algo de errado não está certo! Contate o ADM");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
