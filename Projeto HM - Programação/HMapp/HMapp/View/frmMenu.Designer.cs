namespace HMapp.View
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadPAC = new System.Windows.Forms.Button();
            this.btnCadFun = new System.Windows.Forms.Button();
            this.btnCadMed = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 333);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(233, 58);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCadPAC
            // 
            this.btnCadPAC.Location = new System.Drawing.Point(12, 141);
            this.btnCadPAC.Name = "btnCadPAC";
            this.btnCadPAC.Size = new System.Drawing.Size(233, 58);
            this.btnCadPAC.TabIndex = 11;
            this.btnCadPAC.Text = "Cadastro Paciente";
            this.btnCadPAC.UseVisualStyleBackColor = true;
            this.btnCadPAC.Click += new System.EventHandler(this.btnCadPAC_Click);
            // 
            // btnCadFun
            // 
            this.btnCadFun.Location = new System.Drawing.Point(12, 269);
            this.btnCadFun.Name = "btnCadFun";
            this.btnCadFun.Size = new System.Drawing.Size(233, 58);
            this.btnCadFun.TabIndex = 10;
            this.btnCadFun.Text = "Cadastro Funcionario";
            this.btnCadFun.UseVisualStyleBackColor = true;
            this.btnCadFun.Click += new System.EventHandler(this.btnCadFun_Click);
            // 
            // btnCadMed
            // 
            this.btnCadMed.Location = new System.Drawing.Point(12, 205);
            this.btnCadMed.Name = "btnCadMed";
            this.btnCadMed.Size = new System.Drawing.Size(233, 58);
            this.btnCadMed.TabIndex = 9;
            this.btnCadMed.Text = "Cadastro Medico";
            this.btnCadMed.UseVisualStyleBackColor = true;
            this.btnCadMed.Click += new System.EventHandler(this.btnCadMed_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(12, 77);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(233, 58);
            this.btnHistorico.TabIndex = 8;
            this.btnHistorico.Text = "Consulta Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(12, 13);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(233, 58);
            this.btnConsulta.TabIndex = 7;
            this.btnConsulta.Text = "Nova Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(259, 399);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadPAC);
            this.Controls.Add(this.btnCadFun);
            this.Controls.Add(this.btnCadMed);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadPAC;
        private System.Windows.Forms.Button btnCadFun;
        private System.Windows.Forms.Button btnCadMed;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnConsulta;
    }
}