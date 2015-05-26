namespace AproveitamentoDeNotas
{
    partial class frmCadastraInstCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraInstCurso));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvarInst = new System.Windows.Forms.Button();
            this.txtNomeInstituicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvInstituicao = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clmIdInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstituicao)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvarInst);
            this.groupBox1.Controls.Add(this.txtNomeInstituicao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instituição";
            // 
            // btnSalvarInst
            // 
            this.btnSalvarInst.Location = new System.Drawing.Point(395, 20);
            this.btnSalvarInst.Name = "btnSalvarInst";
            this.btnSalvarInst.Size = new System.Drawing.Size(83, 30);
            this.btnSalvarInst.TabIndex = 14;
            this.btnSalvarInst.Text = "Cadastrar";
            this.btnSalvarInst.UseVisualStyleBackColor = true;
            this.btnSalvarInst.Click += new System.EventHandler(this.btnSalvarInst_Click);
            // 
            // txtNomeInstituicao
            // 
            this.txtNomeInstituicao.Location = new System.Drawing.Point(62, 24);
            this.txtNomeInstituicao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeInstituicao.Name = "txtNomeInstituicao";
            this.txtNomeInstituicao.Size = new System.Drawing.Size(326, 25);
            this.txtNomeInstituicao.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(421, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvInstituicao
            // 
            this.dgvInstituicao.AllowUserToAddRows = false;
            this.dgvInstituicao.AllowUserToDeleteRows = false;
            this.dgvInstituicao.AllowUserToResizeRows = false;
            this.dgvInstituicao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvInstituicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstituicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdInstituicao,
            this.clmInstituicao,
            this.clmDelete});
            this.dgvInstituicao.Location = new System.Drawing.Point(10, 24);
            this.dgvInstituicao.MultiSelect = false;
            this.dgvInstituicao.Name = "dgvInstituicao";
            this.dgvInstituicao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInstituicao.RowHeadersVisible = false;
            this.dgvInstituicao.RowHeadersWidth = 43;
            this.dgvInstituicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstituicao.Size = new System.Drawing.Size(468, 187);
            this.dgvInstituicao.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvInstituicao);
            this.groupBox3.Location = new System.Drawing.Point(12, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 223);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Instiuições";
            // 
            // clmIdInstituicao
            // 
            this.clmIdInstituicao.HeaderText = "ID";
            this.clmIdInstituicao.Name = "clmIdInstituicao";
            this.clmIdInstituicao.Width = 50;
            // 
            // clmInstituicao
            // 
            this.clmInstituicao.HeaderText = "Nome da Instituicao";
            this.clmInstituicao.Name = "clmInstituicao";
            this.clmInstituicao.Width = 350;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Excluir";
            this.clmDelete.Image = ((System.Drawing.Image)(resources.GetObject("clmDelete.Image")));
            this.clmDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Width = 65;
            // 
            // frmCadastraInstCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 358);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastraInstCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastar Instituição";
            this.Load += new System.EventHandler(this.frmCadastraInstCurso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstituicao)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeInstituicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarInst;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvInstituicao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInstituicao;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}