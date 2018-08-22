using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMapp.View
{
    public partial class frmMenu : Form
    {
        
        public frmMenu()
        {
            InitializeComponent();
        }
        public int logado { get; set; }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsulta registro = new frmConsulta();
            registro.ShowDialog();
            this.Visible = true;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHistorico historico = new frmHistorico();
            historico.ShowDialog();
            this.Visible = true;
        }

        private void btnCadPAC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadPac cadastro = new frmCadPac();
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void btnCadMed_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadMed cadastro = new frmCadMed();
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void btnCadFun_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadFun cadastro = new frmCadFun();
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (logado ==1)
            {
                btnCadFun.Enabled = false;
                btnCadMed.Enabled = false;
                btnCadPAC.Enabled = false;
            }
            else if (logado ==2)
            {
                btnConsulta.Enabled = false;
                btnHistorico.Enabled = false;
            }
        }
    }
}
