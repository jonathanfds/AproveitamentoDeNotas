namespace AproveitamentoDeNotas
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCadastrarMateria = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pnlOpenForms = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarMateria
            // 
            this.btnCadastrarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarMateria.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarMateria.Image")));
            this.btnCadastrarMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarMateria.Location = new System.Drawing.Point(18, 12);
            this.btnCadastrarMateria.Name = "btnCadastrarMateria";
            this.btnCadastrarMateria.Size = new System.Drawing.Size(182, 42);
            this.btnCadastrarMateria.TabIndex = 0;
            this.btnCadastrarMateria.Text = "Cadastrar Disciplina";
            this.btnCadastrarMateria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarMateria.UseVisualStyleBackColor = true;
            this.btnCadastrarMateria.Click += new System.EventHandler(this.btnCadastrarMateria_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(18, 60);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(182, 42);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Solicitações";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // pnlOpenForms
            // 
            this.pnlOpenForms.AutoScroll = true;
            this.pnlOpenForms.Location = new System.Drawing.Point(208, 12);
            this.pnlOpenForms.Name = "pnlOpenForms";
            this.pnlOpenForms.Size = new System.Drawing.Size(478, 383);
            this.pnlOpenForms.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCadastrarMateria);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Location = new System.Drawing.Point(-7, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 782);
            this.panel2.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlOpenForms);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Aproveitamento de Notas";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarMateria;
        private System.Windows.Forms.Button btnConsultar;
        public System.Windows.Forms.Panel pnlOpenForms;
        public System.Windows.Forms.Panel panel2;

    }
}