﻿namespace AproveitamentoDeNotas
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
            this.clmIdInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstCursoCadastrados = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstCursosInst = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lklNovoCurso = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstituicao)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.button3.Location = new System.Drawing.Point(421, 575);
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
            this.dgvInstituicao.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstituicao_CellContentDoubleClick);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvInstituicao);
            this.groupBox3.Location = new System.Drawing.Point(12, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 223);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Instiuições";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstCursoCadastrados
            // 
            this.lstCursoCadastrados.FormattingEnabled = true;
            this.lstCursoCadastrados.HorizontalScrollbar = true;
            this.lstCursoCadastrados.ItemHeight = 17;
            this.lstCursoCadastrados.Location = new System.Drawing.Point(10, 41);
            this.lstCursoCadastrados.Name = "lstCursoCadastrados";
            this.lstCursoCadastrados.Size = new System.Drawing.Size(187, 191);
            this.lstCursoCadastrados.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(203, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lstCursosInst
            // 
            this.lstCursosInst.FormattingEnabled = true;
            this.lstCursosInst.HorizontalScrollbar = true;
            this.lstCursosInst.ItemHeight = 17;
            this.lstCursosInst.Location = new System.Drawing.Point(287, 41);
            this.lstCursosInst.Name = "lstCursosInst";
            this.lstCursosInst.Size = new System.Drawing.Size(191, 191);
            this.lstCursosInst.TabIndex = 19;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(203, 77);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(78, 30);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lklNovoCurso
            // 
            this.lklNovoCurso.AutoSize = true;
            this.lklNovoCurso.Location = new System.Drawing.Point(6, 235);
            this.lklNovoCurso.Name = "lklNovoCurso";
            this.lklNovoCurso.Size = new System.Drawing.Size(82, 19);
            this.lklNovoCurso.TabIndex = 21;
            this.lklNovoCurso.TabStop = true;
            this.lklNovoCurso.Text = "Novo Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cursos Cadastrados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(284, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cursos desta instituição";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lklNovoCurso);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.lstCursosInst);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lstCursoCadastrados);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 259);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // frmCadastraInstCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastraInstCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Instituição";
            this.Load += new System.EventHandler(this.frmCadastraInstCurso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstituicao)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstCursoCadastrados;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstCursosInst;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.LinkLabel lklNovoCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}