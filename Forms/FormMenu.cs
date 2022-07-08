using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using estanteTech.FormFuncionario;
using estanteTech.Forms.Formleitor;
using estanteTech.Forms.FormLivro;
using estanteTech.Forms.FormEmprestimo;
using estanteTech.Forms.FormDevolucao;

namespace estanteTech.Forms
{
    public partial class FormMenu : Form
    {
        int id_emprestimo, tipo_funcionario;

        FormCadastroFunc formFunc = new FormCadastroFunc();
        FormCadastroLeitor formLeitor;
        FormCadastroLivro formLivro =  new FormCadastroLivro();
        FormLivroEmprestimo formEmprestimo;
        FormLivroDevolucao formDevolucao = new FormLivroDevolucao();

        private Form formAtivo;


        public FormMenu()
        {
            InitializeComponent();
        }

        public FormMenu(int id_usuario, int tipo_funcionario)
        {
            InitializeComponent();
            id_emprestimo = id_usuario;
            this.tipo_funcionario = tipo_funcionario;
        }

        private void abrirForm(Form form)
        {
            ativaFormFechado();
            formAtivo = form;
            form.TopLevel = false;
            pnlForm.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void ativaFormFechado()
        {
            if (formAtivo != null)
                formAtivo.Hide();
        }

        private void ativaButao(Button formAtivo)
        {
            foreach (Control ctrl in pnlPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            formAtivo.ForeColor = Color.Red;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmar saída!"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (tipo_funcionario == 2)
            {
                MessageBox.Show("Apenas Administradores podem acessar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ativaButao(btnFuncionario);
                abrirForm(formFunc);
            }
        }

        private void btnLeitor_Click(object sender, EventArgs e)
        {
            formLeitor = new FormCadastroLeitor(tipo_funcionario);
            ativaButao(btnLeitor);
            abrirForm(formLeitor);
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            ativaButao(btnLivro);
            abrirForm(formLivro);
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            formEmprestimo = new FormLivroEmprestimo(id_emprestimo);
            ativaButao(btnEmprestimo);
            abrirForm(formEmprestimo);
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            ativaButao(btnDevolucao);
            abrirForm(formDevolucao);
        }
    }
}
