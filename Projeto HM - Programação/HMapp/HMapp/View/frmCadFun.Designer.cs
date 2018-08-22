namespace HMapp.View
{
    partial class frmCadFun
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
            System.Windows.Forms.Label mATRICULALabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label cARGOLabel;
            System.Windows.Forms.Label cOMENTSLabel;
            System.Windows.Forms.Label sENHALabel;
            System.Windows.Forms.Label cNPJ_CLILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFun));
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtComents = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            mATRICULALabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            cARGOLabel = new System.Windows.Forms.Label();
            cOMENTSLabel = new System.Windows.Forms.Label();
            sENHALabel = new System.Windows.Forms.Label();
            cNPJ_CLILabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mATRICULALabel
            // 
            mATRICULALabel.AutoSize = true;
            mATRICULALabel.Location = new System.Drawing.Point(11, 16);
            mATRICULALabel.Name = "mATRICULALabel";
            mATRICULALabel.Size = new System.Drawing.Size(55, 13);
            mATRICULALabel.TabIndex = 21;
            mATRICULALabel.Text = "Matrícula:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(11, 42);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 23;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(11, 68);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 25;
            rGLabel.Text = "RG:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(11, 94);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(38, 13);
            nOMELabel.TabIndex = 27;
            nOMELabel.Text = "Nome:";
            // 
            // cARGOLabel
            // 
            cARGOLabel.AutoSize = true;
            cARGOLabel.Location = new System.Drawing.Point(11, 120);
            cARGOLabel.Name = "cARGOLabel";
            cARGOLabel.Size = new System.Drawing.Size(38, 13);
            cARGOLabel.TabIndex = 29;
            cARGOLabel.Text = "Cargo:";
            // 
            // cOMENTSLabel
            // 
            cOMENTSLabel.AutoSize = true;
            cOMENTSLabel.Location = new System.Drawing.Point(11, 198);
            cOMENTSLabel.Name = "cOMENTSLabel";
            cOMENTSLabel.Size = new System.Drawing.Size(68, 13);
            cOMENTSLabel.TabIndex = 31;
            cOMENTSLabel.Text = "Comentários:";
            // 
            // sENHALabel
            // 
            sENHALabel.AutoSize = true;
            sENHALabel.Location = new System.Drawing.Point(11, 172);
            sENHALabel.Name = "sENHALabel";
            sENHALabel.Size = new System.Drawing.Size(41, 13);
            sENHALabel.TabIndex = 33;
            sENHALabel.Text = "Senha:";
            // 
            // cNPJ_CLILabel
            // 
            cNPJ_CLILabel.AutoSize = true;
            cNPJ_CLILabel.Location = new System.Drawing.Point(11, 146);
            cNPJ_CLILabel.Name = "cNPJ_CLILabel";
            cNPJ_CLILabel.Size = new System.Drawing.Size(76, 13);
            cNPJ_CLILabel.TabIndex = 35;
            cNPJ_CLILabel.Text = "Clínica(CNPJ):";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(106, 13);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(366, 20);
            this.txtMatricula.TabIndex = 22;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(106, 39);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(366, 20);
            this.txtCpf.TabIndex = 24;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(106, 65);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(366, 20);
            this.txtRG.TabIndex = 26;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(366, 20);
            this.txtNome.TabIndex = 28;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(106, 117);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(366, 20);
            this.txtCargo.TabIndex = 30;
            // 
            // txtComents
            // 
            this.txtComents.Location = new System.Drawing.Point(106, 195);
            this.txtComents.Multiline = true;
            this.txtComents.Name = "txtComents";
            this.txtComents.Size = new System.Drawing.Size(366, 159);
            this.txtComents.TabIndex = 32;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(106, 169);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(366, 20);
            this.txtSenha.TabIndex = 34;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(106, 143);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(366, 20);
            this.txtCNPJ.TabIndex = 36;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(156, 359);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 55);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(237, 359);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 55);
            this.btnProcurar.TabIndex = 38;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(318, 359);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 55);
            this.btnSair.TabIndex = 39;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(484, 426);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(mATRICULALabel);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(cARGOLabel);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(cOMENTSLabel);
            this.Controls.Add(this.txtComents);
            this.Controls.Add(sENHALabel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(cNPJ_CLILabel);
            this.Controls.Add(this.txtCNPJ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadFun";
            this.Text = "Cadastro Funcionário";
            this.Load += new System.EventHandler(this.frmCadFun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtComents;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnSair;
    }
}