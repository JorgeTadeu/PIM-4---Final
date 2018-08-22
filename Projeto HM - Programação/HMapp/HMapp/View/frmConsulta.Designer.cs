namespace HMapp.View
{
    partial class frmConsulta
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label cRM_MLabel;
            System.Windows.Forms.Label cPF_PLabel;
            System.Windows.Forms.Label hRA_INICIOLabel;
            System.Windows.Forms.Label hRA_FIMLabel;
            System.Windows.Forms.Label cOMENTSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtHraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtHraFim = new System.Windows.Forms.DateTimePicker();
            this.txtComents = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            cRM_MLabel = new System.Windows.Forms.Label();
            cPF_PLabel = new System.Windows.Forms.Label();
            hRA_INICIOLabel = new System.Windows.Forms.Label();
            hRA_FIMLabel = new System.Windows.Forms.Label();
            cOMENTSLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 14);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 15;
            iDLabel.Text = "ID:";
            // 
            // cRM_MLabel
            // 
            cRM_MLabel.AutoSize = true;
            cRM_MLabel.Location = new System.Drawing.Point(12, 40);
            cRM_MLabel.Name = "cRM_MLabel";
            cRM_MLabel.Size = new System.Drawing.Size(78, 13);
            cRM_MLabel.TabIndex = 17;
            cRM_MLabel.Text = "Médico (CRM):";
            // 
            // cPF_PLabel
            // 
            cPF_PLabel.AutoSize = true;
            cPF_PLabel.Location = new System.Drawing.Point(12, 66);
            cPF_PLabel.Name = "cPF_PLabel";
            cPF_PLabel.Size = new System.Drawing.Size(78, 13);
            cPF_PLabel.TabIndex = 19;
            cPF_PLabel.Text = "Paciente(CPF):";
            // 
            // hRA_INICIOLabel
            // 
            hRA_INICIOLabel.AutoSize = true;
            hRA_INICIOLabel.Location = new System.Drawing.Point(12, 94);
            hRA_INICIOLabel.Name = "hRA_INICIOLabel";
            hRA_INICIOLabel.Size = new System.Drawing.Size(63, 13);
            hRA_INICIOLabel.TabIndex = 23;
            hRA_INICIOLabel.Text = "Hora Início:";
            // 
            // hRA_FIMLabel
            // 
            hRA_FIMLabel.AutoSize = true;
            hRA_FIMLabel.Location = new System.Drawing.Point(12, 120);
            hRA_FIMLabel.Name = "hRA_FIMLabel";
            hRA_FIMLabel.Size = new System.Drawing.Size(52, 13);
            hRA_FIMLabel.TabIndex = 25;
            hRA_FIMLabel.Text = "Hora Fim:";
            // 
            // cOMENTSLabel
            // 
            cOMENTSLabel.AutoSize = true;
            cOMENTSLabel.Location = new System.Drawing.Point(12, 145);
            cOMENTSLabel.Name = "cOMENTSLabel";
            cOMENTSLabel.Size = new System.Drawing.Size(68, 13);
            cOMENTSLabel.TabIndex = 27;
            cOMENTSLabel.Text = "Comentários:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(354, 20);
            this.txtID.TabIndex = 16;
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(118, 37);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(354, 20);
            this.txtCRM.TabIndex = 18;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(118, 63);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(354, 20);
            this.txtCPF.TabIndex = 20;
            // 
            // txtHraInicio
            // 
            this.txtHraInicio.CausesValidation = false;
            this.txtHraInicio.CustomFormat = "dd-MM-yyyy, HH:mm";
            this.txtHraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHraInicio.Location = new System.Drawing.Point(118, 90);
            this.txtHraInicio.Name = "txtHraInicio";
            this.txtHraInicio.Size = new System.Drawing.Size(354, 20);
            this.txtHraInicio.TabIndex = 24;
            // 
            // txtHraFim
            // 
            this.txtHraFim.CustomFormat = "dd-MM-yyyy, HH:mm";
            this.txtHraFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHraFim.Location = new System.Drawing.Point(118, 116);
            this.txtHraFim.Name = "txtHraFim";
            this.txtHraFim.Size = new System.Drawing.Size(354, 20);
            this.txtHraFim.TabIndex = 26;
            // 
            // txtComents
            // 
            this.txtComents.Location = new System.Drawing.Point(118, 142);
            this.txtComents.Multiline = true;
            this.txtComents.Name = "txtComents";
            this.txtComents.Size = new System.Drawing.Size(354, 206);
            this.txtComents.TabIndex = 28;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(196, 354);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 48);
            this.btnSalvar.TabIndex = 45;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(277, 354);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 48);
            this.btnSair.TabIndex = 47;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(cRM_MLabel);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(cPF_PLabel);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(hRA_INICIOLabel);
            this.Controls.Add(this.txtHraInicio);
            this.Controls.Add(hRA_FIMLabel);
            this.Controls.Add(this.txtHraFim);
            this.Controls.Add(cOMENTSLabel);
            this.Controls.Add(this.txtComents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsulta";
            this.Text = "Nova Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.DateTimePicker txtHraInicio;
        private System.Windows.Forms.DateTimePicker txtHraFim;
        private System.Windows.Forms.TextBox txtComents;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
    }
}