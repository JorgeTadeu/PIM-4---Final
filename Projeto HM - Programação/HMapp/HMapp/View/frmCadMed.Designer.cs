namespace HMapp.View
{
    partial class frmCadMed
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
            System.Windows.Forms.Label cRMLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label eSPECLabel;
            System.Windows.Forms.Label cOMENTSLabel;
            System.Windows.Forms.Label sENHALabel;
            System.Windows.Forms.Label cNPJ_CLILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadMed));
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEspec = new System.Windows.Forms.TextBox();
            this.txtComents = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            cRMLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            eSPECLabel = new System.Windows.Forms.Label();
            cOMENTSLabel = new System.Windows.Forms.Label();
            sENHALabel = new System.Windows.Forms.Label();
            cNPJ_CLILabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cRMLabel
            // 
            cRMLabel.AutoSize = true;
            cRMLabel.Location = new System.Drawing.Point(15, 14);
            cRMLabel.Name = "cRMLabel";
            cRMLabel.Size = new System.Drawing.Size(34, 13);
            cRMLabel.TabIndex = 17;
            cRMLabel.Text = "CRM:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(15, 40);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(38, 13);
            nOMELabel.TabIndex = 19;
            nOMELabel.Text = "Nome:";
            // 
            // eSPECLabel
            // 
            eSPECLabel.AutoSize = true;
            eSPECLabel.Location = new System.Drawing.Point(15, 66);
            eSPECLabel.Name = "eSPECLabel";
            eSPECLabel.Size = new System.Drawing.Size(76, 13);
            eSPECLabel.TabIndex = 21;
            eSPECLabel.Text = "Especialidade:";
            // 
            // cOMENTSLabel
            // 
            cOMENTSLabel.AutoSize = true;
            cOMENTSLabel.Location = new System.Drawing.Point(15, 145);
            cOMENTSLabel.Name = "cOMENTSLabel";
            cOMENTSLabel.Size = new System.Drawing.Size(68, 13);
            cOMENTSLabel.TabIndex = 23;
            cOMENTSLabel.Text = "Comentários:";
            // 
            // sENHALabel
            // 
            sENHALabel.AutoSize = true;
            sENHALabel.Location = new System.Drawing.Point(15, 119);
            sENHALabel.Name = "sENHALabel";
            sENHALabel.Size = new System.Drawing.Size(41, 13);
            sENHALabel.TabIndex = 25;
            sENHALabel.Text = "Senha:";
            // 
            // cNPJ_CLILabel
            // 
            cNPJ_CLILabel.AutoSize = true;
            cNPJ_CLILabel.Location = new System.Drawing.Point(15, 92);
            cNPJ_CLILabel.Name = "cNPJ_CLILabel";
            cNPJ_CLILabel.Size = new System.Drawing.Size(76, 13);
            cNPJ_CLILabel.TabIndex = 27;
            cNPJ_CLILabel.Text = "Clínica(CNPJ):";
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(118, 11);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(354, 20);
            this.txtCRM.TabIndex = 18;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(354, 20);
            this.txtNome.TabIndex = 20;
            // 
            // txtEspec
            // 
            this.txtEspec.Location = new System.Drawing.Point(118, 63);
            this.txtEspec.Name = "txtEspec";
            this.txtEspec.Size = new System.Drawing.Size(354, 20);
            this.txtEspec.TabIndex = 22;
            // 
            // txtComents
            // 
            this.txtComents.Location = new System.Drawing.Point(118, 142);
            this.txtComents.Multiline = true;
            this.txtComents.Name = "txtComents";
            this.txtComents.Size = new System.Drawing.Size(354, 215);
            this.txtComents.TabIndex = 24;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(118, 116);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(354, 20);
            this.txtSenha.TabIndex = 26;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(118, 89);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(354, 20);
            this.txtCNPJ.TabIndex = 28;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(334, 363);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 48);
            this.btnSair.TabIndex = 47;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(253, 363);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 48);
            this.btnProcurar.TabIndex = 46;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(172, 363);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 48);
            this.btnSalvar.TabIndex = 45;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(484, 416);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(cRMLabel);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(eSPECLabel);
            this.Controls.Add(this.txtEspec);
            this.Controls.Add(cOMENTSLabel);
            this.Controls.Add(this.txtComents);
            this.Controls.Add(sENHALabel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(cNPJ_CLILabel);
            this.Controls.Add(this.txtCNPJ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadMed";
            this.Text = "Cadastro Médico";
            this.Load += new System.EventHandler(this.frmCadMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEspec;
        private System.Windows.Forms.TextBox txtComents;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnSalvar;
    }
}