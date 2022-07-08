using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using estanteTech.SQL;
using estanteTech.Modelo;

namespace estanteTech.FormFuncionario
{
    public partial class FormAddEditFunc : Form
    {
        private FuncionarioSQL funcionarioSQL = new FuncionarioSQL();
        private Funcionario func = new Funcionario();
        private int id;
        private DataGridView dgvFuncionario;

        public FormAddEditFunc(DataGridView dgv)
        {
            InitializeComponent();
            dgvFuncionario = dgv;
        }

        public bool valida()
        {
            if (String.IsNullOrWhiteSpace(tbNome.Text) || String.IsNullOrWhiteSpace(mtbTelefone.Text) ||
                String.IsNullOrWhiteSpace(tbEmail.Text) || String.IsNullOrWhiteSpace(tbUsuario.Text) ||
                String.IsNullOrWhiteSpace(tbSenha.Text) || String.IsNullOrWhiteSpace(cbxTipoUsuario.Text))
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
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "";
                }
            }
        }

        public FormAddEditFunc(Funcionario funcionario, DataGridView dgv)
        {
            InitializeComponent();
            dgvFuncionario = dgv;
            id = funcionario.getId_funcionario();
            tbNome.Text = funcionario.getNome();
            tbEmail.Text = funcionario.getEmail();
            mtbTelefone.Text = Convert.ToString(funcionario.getTelefone());
            tbUsuario.Text = funcionario.getUsuario();
            tbSenha.Text = funcionario.getSenha();
            cbxTipoUsuario.SelectedIndex = funcionario.getTipo_usuario();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool resultado = valida();
            int usuarioExistente = funcionarioSQL.verificaUsuarioExistente(tbUsuario.Text);

            if (resultado == true)
            {
                if (usuarioExistente != 0)
                {
                    MessageBox.Show("Usuário não disponível!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    func.setId_funcionario(id);
                    func.setNome(tbNome.Text);
                    func.setEmail(tbEmail.Text);
                    func.setTelefone(Convert.ToDouble(mtbTelefone.Text));
                    func.setUsuario(tbUsuario.Text);
                    func.setSenha(tbSenha.Text);
                    func.setTipo_usuario(cbxTipoUsuario.SelectedIndex + 1);

                    if (func.getId_funcionario() == 0)
                    {
                        funcionarioSQL.incluir(func);
                        MessageBox.Show("Funcionário Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCampos(this);
                    }
                    else
                    {
                        funcionarioSQL.atualziar(func);
                        MessageBox.Show("Funcionário Atualizado com Sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void FormAddEditFunc_FormClosing(object sender, FormClosingEventArgs e)
        {
            funcionarioSQL.getFuncionario(dgvFuncionario);
        }
    }
}
