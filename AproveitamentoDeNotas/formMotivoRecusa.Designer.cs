namespace AproveitamentoDeNotas
{
    partial class formMotivoRecusa
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
            this.rdbIncompCH = new System.Windows.Forms.RadioButton();
            this.rdbIncompProg = new System.Windows.Forms.RadioButton();
            this.rdbIncompCHeProg = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbIncompCH
            // 
            this.rdbIncompCH.AutoSize = true;
            this.rdbIncompCH.Location = new System.Drawing.Point(9, 11);
            this.rdbIncompCH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbIncompCH.Name = "rdbIncompCH";
            this.rdbIncompCH.Size = new System.Drawing.Size(335, 23);
            this.rdbIncompCH.TabIndex = 1;
            this.rdbIncompCH.TabStop = true;
            this.rdbIncompCH.Text = "Incompatibilidade de carga horária (inferior a 50%)";
            this.rdbIncompCH.UseVisualStyleBackColor = true;
            this.rdbIncompCH.CheckedChanged += new System.EventHandler(this.rdbIncompCH_CheckedChanged);
            // 
            // rdbIncompProg
            // 
            this.rdbIncompProg.AutoSize = true;
            this.rdbIncompProg.Location = new System.Drawing.Point(9, 54);
            this.rdbIncompProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbIncompProg.Name = "rdbIncompProg";
            this.rdbIncompProg.Size = new System.Drawing.Size(302, 23);
            this.rdbIncompProg.TabIndex = 2;
            this.rdbIncompProg.TabStop = true;
            this.rdbIncompProg.Text = "Incompatibilidade de conteúdo programático";
            this.rdbIncompProg.UseVisualStyleBackColor = true;
            this.rdbIncompProg.CheckedChanged += new System.EventHandler(this.rdbIncompProg_CheckedChanged);
            // 
            // rdbIncompCHeProg
            // 
            this.rdbIncompCHeProg.AutoSize = true;
            this.rdbIncompCHeProg.Location = new System.Drawing.Point(9, 100);
            this.rdbIncompCHeProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbIncompCHeProg.Name = "rdbIncompCHeProg";
            this.rdbIncompCHeProg.Size = new System.Drawing.Size(494, 23);
            this.rdbIncompCHeProg.TabIndex = 3;
            this.rdbIncompCHeProg.TabStop = true;
            this.rdbIncompCHeProg.Text = "Incompatibilidade de carga horária (inferior a 50%) e conteúdo programático";
            this.rdbIncompCHeProg.UseVisualStyleBackColor = true;
            this.rdbIncompCHeProg.CheckedChanged += new System.EventHandler(this.rdbIncompCHeProg_CheckedChanged);
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
            this.panel1.Size = new System.Drawing.Size(512, 173);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(420, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formMotivoRecusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 175);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formMotivoRecusa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motivo ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbIncompCH;
        private System.Windows.Forms.RadioButton rdbIncompProg;
        private System.Windows.Forms.RadioButton rdbIncompCHeProg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
    }
}