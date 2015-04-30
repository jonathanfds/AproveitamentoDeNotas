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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCadastrarMateria
            // 
            this.btnCadastrarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarMateria.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarMateria.Image")));
            this.btnCadastrarMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarMateria.Location = new System.Drawing.Point(6, 12);
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
            this.btnConsultar.Location = new System.Drawing.Point(6, 60);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(182, 42);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Solicitações";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(194, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 406);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(6, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 48);
            this.panel2.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrarMateria);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarMateria;
        private System.Windows.Forms.Button btnConsultar;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

    }
}