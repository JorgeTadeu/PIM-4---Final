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
    public partial class frmCadFun : Form
    {
        Funcionarios funcionario = new Funcionarios();
        DaoFuncionarios d_fun = new DaoFuncionarios();
        public frmCadFun()
        {
            InitializeComponent();
        }

        private void frmCadFun_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            funcionario.matricula = Convert.ToInt16(txtMatricula.Text);
            funcionario.rg = Convert.ToInt16(txtRG.Text);
            funcionario.nome = txtNome.Text;
            funcionario.cargo = txtCargo.Text;
            funcionario.coments = txtComents.Text;
            funcionario.senha = txtSenha.Text;
            funcionario.cli.cnpj= Convert.ToInt16(txtCNPJ.Text);

            d_fun.Insert(funcionario);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            funcionario.matricula = Convert.ToInt16(txtMatricula.Text);
            funcionario = d_fun.BuscarPorMatricula(funcionario.matricula);

            txtMatricula.Text = Convert.ToString(funcionario.matricula);
            txtRG.Text = Convert.ToString(funcionario.rg);
            txtNome.Text = funcionario.nome;
            txtCargo.Text = funcionario.cargo;
            txtComents.Text = Convert.ToString(funcionario.coments);
            txtCNPJ.Text = Convert.ToString(funcionario.cli.cnpj);

        }
       
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
