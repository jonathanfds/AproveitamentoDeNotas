namespace AproveitamentoDeNotas
{
    partial class frmMotivoExame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbIncompCH = new System.Windows.Forms.RadioButton();
            this.rdbIncompProg = new System.Windows.Forms.RadioButton();
            this.rdbIncompCHeProg = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rdbIncompCH);
            this.panel1.Controls.Add(this.rdbIncompProg);
            this.panel1.Controls.Add(this.rdbIncompCHeProg);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 168);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(478, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rdbIncompCH
            // 
            this.rdbIncompCH.AutoSize = true;
            this.rdbIncompCH.Location = new System.Drawing.Point(9, 11);
            this.rdbIncompCH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbIncompCH.Name = "rdbIncompCH";
            this.rdbIncompCH.Size = new System.Drawing.Size(389, 23);
            this.rdbIncompCH.TabIndex = 1;
            this.rdbIncompCH.TabStop = true;
            this.rdbIncompCH.Text = "Compatibilidade parcial da carga horária (entre 50% a 70%)\r\n";
            this.rdbIncompCH.UseVisualStyleBackColor = true;
            // 
            // rdbIncompProg
            // 
            this.rdbIncompProg.AutoSize = true;
            this.rdbIncompProg.Location = new System.Drawing.Point(9, 54);
            this.rdbIncompProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbIncompProg.Name = "rdbIncompProg";
            this.rdbIncompProg.Size = new System.Drawing.Size(337, 23);
            this.rdbIncompProg.TabIndex = 2;
            this.rdbIncompProg.TabStop = true;
            this.rdbIncompProg.Text = "Compatibilidade parcial do conteúdo programático";
            this.rdbIncompProg.UseVisualStyleBackColor = true;
            // 
            // rdbIncompCHeProg
            // 
            this.rdbIncompCHeProg.AutoSize = true;
            this.rdbIncompCHeProg.Location = new System.Drawing.Point(9, 100);
            this.rdbIncompCHeProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbIncompCHeProg.Name = "rdbIncompCHeProg";
            this.rdbIncompCHeProg.Size = new System.Drawing.Size(549, 23);
            this.rdbIncompCHeProg.TabIndex = 3;
            this.rdbIncompCHeProg.TabStop = true;
            this.rdbIncompCHeProg.Text = "Compatibilidade parcial do conteúdo programático e carga horária( entre 50% a 70%" +
    ")";
            this.rdbIncompCHeProg.UseVisualStyleBackColor = true;
            // 
            // frmMotivoExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 169);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMotivoExame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motivo Exame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbIncompCH;
        private System.Windows.Forms.RadioButton rdbIncompProg;
        private System.Windows.Forms.RadioButton rdbIncompCHeProg;

    }
}