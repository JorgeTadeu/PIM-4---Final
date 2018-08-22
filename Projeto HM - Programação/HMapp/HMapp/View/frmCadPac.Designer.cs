namespace HMapp.View
{
    partial class frmCadPac
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
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label sANGUELabel;
            System.Windows.Forms.Label sEXOLabel;
            System.Windows.Forms.Label cOMENTSLabel;
            System.Windows.Forms.Label sENHALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPac));
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSangue = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtComents = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            sANGUELabel = new System.Windows.Forms.Label();
            sEXOLabel = new System.Windows.Forms.Label();
            cOMENTSLabel = new System.Windows.Forms.Label();
            sENHALabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(14, 10);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 23;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(14, 36);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 25;
            rGLabel.Text = "RG:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(14, 62);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(38, 13);
            nOMELabel.TabIndex = 27;
            nOMELabel.Text = "Nome:";
            // 
            // sANGUELabel
            // 
            sANGUELabel.AutoSize = true;
            sANGUELabel.Location = new System.Drawing.Point(14, 88);
            sANGUELabel.Name = "sANGUELabel";
            sANGUELabel.Size = new System.Drawing.Size(47, 13);
            sANGUELabel.TabIndex = 29;
            sANGUELabel.Text = "Sangue:";
            // 
            // sEXOLabel
            // 
            sEXOLabel.AutoSize = true;
            sEXOLabel.Location = new System.Drawing.Point(14, 114);
            sEXOLabel.Name = "sEXOLabel";
            sEXOLabel.Size = new System.Drawing.Size(34, 13);
            sEXOLabel.TabIndex = 31;
            sEXOLabel.Text = "Sexo:";
            // 
            // cOMENTSLabel
            // 
            cOMENTSLabel.AutoSize = true;
            cOMENTSLabel.Location = new System.Drawing.Point(14, 167);
            cOMENTSLabel.Name = "cOMENTSLabel";
            cOMENTSLabel.Size = new System.Drawing.Size(68, 13);
            cOMENTSLabel.TabIndex = 37;
            cOMENTSLabel.Text = "Comentários:";
            // 
            // sENHALabel
            // 
            sENHALabel.AutoSize = true;
            sENHALabel.Location = new System.Drawing.Point(14, 141);
            sENHALabel.Name = "sENHALabel";
            sENHALabel.Size = new System.Drawing.Size(41, 13);
            sENHALabel.TabIndex = 39;
            sENHALabel.Text = "Senha:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(115, 7);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(348, 20);
            this.txtCPF.TabIndex = 24;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(115, 33);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(348, 20);
            this.txtRG.TabIndex = 26;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(348, 20);
            this.txtNome.TabIndex = 28;
            // 
            // txtSangue
            // 
            this.txtSangue.Location = new System.Drawing.Point(115, 85);
            this.txtSangue.Name = "txtSangue";
            this.txtSangue.Size = new System.Drawing.Size(348, 20);
            this.txtSangue.TabIndex = 30;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(115, 111);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(348, 20);
            this.txtSexo.TabIndex = 32;
            // 
            // txtComents
            // 
            this.txtComents.Location = new System.Drawing.Point(115, 164);
            this.txtComents.Multiline = true;
            this.txtComents.Name = "txtComents";
            this.txtComents.Size = new System.Drawing.Size(348, 136);
            this.txtComents.TabIndex = 38;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(115, 138);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(348, 20);
            this.txtSenha.TabIndex = 40;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(115, 306);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 48);
            this.btnSalvar.TabIndex = 41;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(358, 306);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 48);
            this.btnSair.TabIndex = 43;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(196, 306);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 48);
            this.btnProcurar.TabIndex = 42;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(277, 306);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 48);
            this.btnConsulta.TabIndex = 44;
            this.btnConsulta.Text = "Nova Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // frmCadPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(485, 372);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(sANGUELabel);
            this.Controls.Add(this.txtSangue);
            this.Controls.Add(sEXOLabel);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(cOMENTSLabel);
            this.Controls.Add(this.txtComents);
            this.Controls.Add(sENHALabel);
            this.Controls.Add(this.txtSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadPac";
            this.Text = "Cadastro Paciente";
            this.Load += new System.EventHandler(this.frmCadPac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSangue;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtComents;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnConsulta;
    }
}