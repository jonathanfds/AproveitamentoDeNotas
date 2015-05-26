﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AproveitamentoDeNotas
{
    public partial class frmLogin : Form
    {        
        public frmLogin()
        {
            InitializeComponent();
        }


        private bool ChecarUsuario(string pUser,string pPassword)
        {
            TB_USUARIOS lUsuario = clsFuncoesBase.getUsuarios(pUser, pPassword);
            if (lUsuario != null)
            {
                clsGlobal.UsuarioLogado = lUsuario;
                return true;
            }
            else
            {
                return false;                
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string lUser = this.txtUser.Text;
            string lPassword = this.txtSenha.Text;
            if (!string.IsNullOrEmpty(lUser) && !string.IsNullOrEmpty(lPassword))
            {
                if (ChecarUsuario(lUser,lPassword))
                {
                    new frmMain().Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                }
            }
            else
            {
                MessageBox.Show("Preencha usuário e senha.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
