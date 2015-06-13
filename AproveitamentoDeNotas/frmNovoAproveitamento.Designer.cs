namespace AproveitamentoDeNotas
{
    partial class frmNovoAproveitamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lklNovoDisciplina = new System.Windows.Forms.LinkLabel();
            this.lklNovoCurso = new System.Windows.Forms.LinkLabel();
            this.lklNovoInst = new System.Windows.Forms.LinkLabel();
            this.txtAnoSemestre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricaoOrigem = new System.Windows.Forms.TextBox();
            this.cmbDisciplinaOrigem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCursoOrigem = new System.Windows.Forms.ComboBox();
            this.cmbInstituicaoOrigem = new System.Windows.Forms.ComboBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCursoAluno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDisciplinaAluno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lklNovoDisciplina);
            this.groupBox1.Controls.Add(this.lklNovoCurso);
            this.groupBox1.Controls.Add(this.lklNovoInst);
            this.groupBox1.Controls.Add(this.txtAnoSemestre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDescricaoOrigem);
            this.groupBox1.Controls.Add(this.cmbDisciplinaOrigem);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbCursoOrigem);
            this.groupBox1.Controls.Add(this.cmbInstituicaoOrigem);
            this.groupBox1.Controls.Add(this.txtCargaHoraria);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(486, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formação de Origem";
            // 
            // lklNovoDisciplina
            // 
            this.lklNovoDisciplina.AutoSize = true;
            this.lklNovoDisciplina.Enabled = false;
            this.lklNovoDisciplina.Location = new System.Drawing.Point(385, 114);
            this.lklNovoDisciplina.Name = "lklNovoDisciplina";
            this.lklNovoDisciplina.Size = new System.Drawing.Size(41, 17);
            this.lklNovoDisciplina.TabIndex = 39;
            this.lklNovoDisciplina.TabStop = true;
            this.lklNovoDisciplina.Text = "Novo";
            this.lklNovoDisciplina.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // lklNovoCurso
            // 
            this.lklNovoCurso.AutoSize = true;
            this.lklNovoCurso.Enabled = false;
            this.lklNovoCurso.Location = new System.Drawing.Point(385, 71);
            this.lklNovoCurso.Name = "lklNovoCurso";
            this.lklNovoCurso.Size = new System.Drawing.Size(41, 17);
            this.lklNovoCurso.TabIndex = 38;
            this.lklNovoCurso.TabStop = true;
            this.lklNovoCurso.Text = "Novo";
            this.lklNovoCurso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lklNovoInst
            // 
            this.lklNovoInst.AutoSize = true;
            this.lklNovoInst.Enabled = false;
            this.lklNovoInst.Location = new System.Drawing.Point(385, 32);
            this.lklNovoInst.Name = "lklNovoInst";
            this.lklNovoInst.Size = new System.Drawing.Size(41, 17);
            this.lklNovoInst.TabIndex = 37;
            this.lklNovoInst.TabStop = true;
            this.lklNovoInst.Text = "Novo";
            this.lklNovoInst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtAnoSemestre
            // 
            this.txtAnoSemestre.Enabled = false;
            this.txtAnoSemestre.Location = new System.Drawing.Point(109, 152);
            this.txtAnoSemestre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnoSemestre.Name = "txtAnoSemestre";
            this.txtAnoSemestre.ReadOnly = true;
            this.txtAnoSemestre.Size = new System.Drawing.Size(80, 25);
            this.txtAnoSemestre.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Descrição:";
            // 
            // txtDescricaoOrigem
            // 
            this.txtDescricaoOrigem.Enabled = false;
            this.txtDescricaoOrigem.Location = new System.Drawing.Point(108, 197);
            this.txtDescricaoOrigem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricaoOrigem.Multiline = true;
            this.txtDescricaoOrigem.Name = "txtDescricaoOrigem";
            this.txtDescricaoOrigem.ReadOnly = true;
            this.txtDescricaoOrigem.Size = new System.Drawing.Size(371, 111);
            this.txtDescricaoOrigem.TabIndex = 31;
            // 
            // cmbDisciplinaOrigem
            // 
            this.cmbDisciplinaOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplinaOrigem.Enabled = false;
            this.cmbDisciplinaOrigem.FormattingEnabled = true;
            this.cmbDisciplinaOrigem.Location = new System.Drawing.Point(109, 111);
            this.cmbDisciplinaOrigem.Name = "cmbDisciplinaOrigem";
            this.cmbDisciplinaOrigem.Size = new System.Drawing.Size(270, 25);
            this.cmbDisciplinaOrigem.TabIndex = 36;
            this.cmbDisciplinaOrigem.SelectedIndexChanged += new System.EventHandler(this.cmbDisciplinaOrigem_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Curso:";
            // 
            // cmbCursoOrigem
            // 
            this.cmbCursoOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursoOrigem.Enabled = false;
            this.cmbCursoOrigem.FormattingEnabled = true;
            this.cmbCursoOrigem.Location = new System.Drawing.Point(108, 71);
            this.cmbCursoOrigem.Name = "cmbCursoOrigem";
            this.cmbCursoOrigem.Size = new System.Drawing.Size(271, 25);
            this.cmbCursoOrigem.TabIndex = 33;
            this.cmbCursoOrigem.SelectedIndexChanged += new System.EventHandler(this.cmbCursoOrigem_SelectedIndexChanged);
            // 
            // cmbInstituicaoOrigem
            // 
            this.cmbInstituicaoOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstituicaoOrigem.Enabled = false;
            this.cmbInstituicaoOrigem.FormattingEnabled = true;
            this.cmbInstituicaoOrigem.Location = new System.Drawing.Point(109, 32);
            this.cmbInstituicaoOrigem.Name = "cmbInstituicaoOrigem";
            this.cmbInstituicaoOrigem.Size = new System.Drawing.Size(270, 25);
            this.cmbInstituicaoOrigem.TabIndex = 32;
            this.cmbInstituicaoOrigem.SelectedIndexChanged += new System.EventHandler(this.cmbInstituicaoOrigem_SelectedIndexChanged);
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Enabled = false;
            this.txtCargaHoraria.Location = new System.Drawing.Point(299, 152);
            this.txtCargaHoraria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.ReadOnly = true;
            this.txtCargaHoraria.Size = new System.Drawing.Size(80, 25);
            this.txtCargaHoraria.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Instituição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Ano/Semestre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(197, 155);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Carga Horária:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Disciplina:";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(72, 15);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(162, 25);
            this.txtRA.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "RA :";
            // 
            // cmbCursoAluno
            // 
            this.cmbCursoAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursoAluno.FormattingEnabled = true;
            this.cmbCursoAluno.Location = new System.Drawing.Point(316, 15);
            this.cmbCursoAluno.Name = "cmbCursoAluno";
            this.cmbCursoAluno.Size = new System.Drawing.Size(191, 25);
            this.cmbCursoAluno.TabIndex = 6;
            this.cmbCursoAluno.SelectedIndexChanged += new System.EventHandler(this.cmbCursoAluno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Disciplina :";
            // 
            // cmbDisciplinaAluno
            // 
            this.cmbDisciplinaAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplinaAluno.FormattingEnabled = true;
            this.cmbDisciplinaAluno.Location = new System.Drawing.Point(316, 52);
            this.cmbDisciplinaAluno.Name = "cmbDisciplinaAluno";
            this.cmbDisciplinaAluno.Size = new System.Drawing.Size(191, 25);
            this.cmbDisciplinaAluno.TabIndex = 4;
            this.cmbDisciplinaAluno.SelectedIndexChanged += new System.EventHandler(this.cmbDisciplinaAluno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Curso :";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(72, 52);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(162, 25);
            this.txtNomeAluno.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aluno :";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(333, 411);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 30);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(424, 411);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 30);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNovoAproveitamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 449);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbCursoAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.cmbDisciplinaAluno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNovoAproveitamento";
            this.ShowIcon = false;
            this.Text = "Novo Aproveitamento";
            this.Load += new System.EventHandler(this.frmNovoAproveitamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCursoAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDisciplinaAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDescricaoOrigem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnoSemestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCursoOrigem;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbInstituicaoOrigem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDisciplinaOrigem;
        private System.Windows.Forms.LinkLabel lklNovoDisciplina;
        private System.Windows.Forms.LinkLabel lklNovoCurso;
        private System.Windows.Forms.LinkLabel lklNovoInst;
    }
}