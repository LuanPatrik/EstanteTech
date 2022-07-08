using estanteTech.Modelo;
using estanteTech.SQL;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Session = MySqlX.XDevAPI.Session;

namespace estanteTech.Forms.FormLogin
{
    public partial class FormTelaLogin : Form
    {
        LoginSQL loginSQL = new LoginSQL();

        public FormTelaLogin()
        {
            InitializeComponent();
            tbSenha.UseSystemPasswordChar = true;
        }

        public bool valida()
        {
            if (String.IsNullOrWhiteSpace(tbUsuario.Text) || String.IsNullOrWhiteSpace(tbSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void limparCampos(Control crtl)
        {
            foreach (Control c in crtl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool result = valida();

            if (result == true)
            {
                String usuario = tbUsuario.Text;
                String senha = tbSenha.Text;

                int id_funcionario = loginSQL.verificaID(usuario, senha);
                int tipo_funcionairo = loginSQL.credencial(id_funcionario);

                if (id_funcionario != 0)
                {
                    this.Hide();
                    FormMenu form = new FormMenu(id_funcionario, tipo_funcionairo);
                    form.Show();
                }
                else
                {
                    limparCampos(this);
                    MessageBox.Show("Usuário ou senha Inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSenha.Checked)
            {
                tbSenha.UseSystemPasswordChar = false;
            }
            else
            {
                tbSenha.UseSystemPasswordChar = true;
            }
        }

        private void FormTelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* form = new FormTelaLogin();
            form.Close();*/
        }
    }
}
