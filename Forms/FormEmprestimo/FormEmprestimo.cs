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

namespace estanteTech.Forms.FormEmprestimo
{
    public partial class FormEmprestimo : Form
    {
        EmprestimoSQL emprestimoSQL = new EmprestimoSQL();
        Emprestimo emprestimo = new Emprestimo();
        LoginSQL loginSQL = new LoginSQL();
        DataGridView dgvEmprestimo;

        public FormEmprestimo()
        {
            InitializeComponent();
        }

        public FormEmprestimo(int id_livro, int id_funcionario, DataGridView dgv)
        {
            InitializeComponent();
            dgvEmprestimo = dgv;
            emprestimo.setId_livro(id_livro);
            emprestimo.setId_funcionario(id_funcionario);
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

        private void button1_Click(object sender, EventArgs e)
        {
            emprestimoSQL.listaLeitor(cbxLeitor, cbxLeitor.Text);
            emprestimo.setId_leitor((int)cbxLeitor.SelectedValue);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            emprestimo.SetData_emprestimo(Convert.ToDateTime(dtpDataEmprestimo.Text));
            emprestimo.setData_devolucao(Convert.ToDateTime(dtpDataDevolucao.Text));
            emprestimo.setId_status(1);
            emprestimo.getId_livro();
            emprestimo.getId_leitor();
            emprestimo.getId_funcionario();

            emprestimoSQL.incluir(emprestimo);
            limparCampos(this);

            MessageBox.Show("Livro Emprestado com Sucesso!", "Emprestimo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormEmprestimo_FormClosing(object sender, FormClosingEventArgs e)
        {
            emprestimoSQL.getLivro(dgvEmprestimo);
        }
    }
}
