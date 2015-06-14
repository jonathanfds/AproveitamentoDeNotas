namespace AproveitamentoDeNotas
{
    partial class frmConsultarRequerimentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmRa,
            this.clmNome,
            this.clmCurso,
            this.clmSituacao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmRa
            // 
            this.clmRa.HeaderText = "RA";
            this.clmRa.Name = "clmRa";
            this.clmRa.ReadOnly = true;
            this.clmRa.Width = 130;
            // 
            // clmNome
            // 
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.Width = 280;
            // 
            // clmCurso
            // 
            this.clmCurso.HeaderText = "Curso";
            this.clmCurso.Name = "clmCurso";
            this.clmCurso.ReadOnly = true;
            this.clmCurso.Width = 270;
            // 
            // clmSituacao
            // 
            this.clmSituacao.HeaderText = "Situação";
            this.clmSituacao.Name = "clmSituacao";
            this.clmSituacao.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(228, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 25);
            this.txtNome.TabIndex = 1;
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(471, 16);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(130, 25);
            this.txtRA.TabIndex = 2;
            this.txtRA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "RA :";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.Location = new System.Drawing.Point(813, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(83, 30);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(677, 16);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(130, 25);
            this.cmbSituacao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Situação :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código :";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(73, 16);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(79, 25);
            this.txtCod.TabIndex = 0;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // frmConsultarRequerimentos
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 396);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultarRequerimentos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Aproveitamentos";
            this.Load += new System.EventHandler(this.frmConsultarRequerimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSituacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCod;
    }
}