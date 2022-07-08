using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using estanteTech.Modelo;
using estanteTech.SQL;

namespace estanteTech.Forms.FormLivro
{
    public partial class FormAddEditLivro : Form
    {
        Livro livro = new Livro();
        LivroSQL livroSQL = new LivroSQL();
        private int id;
        DataGridView dgvLivro;

        public FormAddEditLivro(DataGridView dgv)
        {
            InitializeComponent();
            dgvLivro = dgv;
        }

        public bool valida()
        {
            if (String.IsNullOrWhiteSpace(tbTitulo.Text) || String.IsNullOrWhiteSpace(tbEdicao.Text) ||
                String.IsNullOrWhiteSpace(tbEditora.Text) || String.IsNullOrWhiteSpace(tbAutor.Text) ||
                String.IsNullOrWhiteSpace(tbGenero.Text) || String.IsNullOrWhiteSpace(tbQtPagina.Text) ||
                String.IsNullOrWhiteSpace(tbAnoPublicacao.Text) || String.IsNullOrWhiteSpace(tbIdioma.Text) ||
                String.IsNullOrWhiteSpace(tbCodigoISBN.Text))
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

        public FormAddEditLivro(Livro livro, DataGridView dgv)
        {
            InitializeComponent();
            dgvLivro = dgv;

            id = livro.getId_livro();
            tbTitulo.Text = livro.getTitulo();
            tbEditora.Text = livro.getEditora();
            tbEdicao.Text = livro.getEdicao();
            tbAutor.Text = livro.getAutor();
            tbGenero.Text = livro.getGenero();
            tbAnoPublicacao.Text = Convert.ToString(livro.getAno_publicacao());
            tbIdioma.Text = livro.getIdioma();
            tbQtPagina.Text = Convert.ToString(livro.getQt_pagina());
            tbCodigoISBN.Text = livro.getCod_ISBN();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool resultado = valida();

            if (resultado == true)
            {
                livro.setId_livro(id);
                livro.setTitulo(tbTitulo.Text);
                livro.setEditora(tbEditora.Text);
                livro.setEdicao(tbEdicao.Text);
                livro.setAutor(tbAutor.Text);
                livro.setGenero(tbGenero.Text);
                livro.setAno_publicacao(Convert.ToInt32(tbAnoPublicacao.Text));
                livro.setIdioma(tbIdioma.Text);
                livro.setQt_pagina(Convert.ToInt32(tbQtPagina.Text));
                livro.setCod_ISBN(tbCodigoISBN.Text);
                livro.setId_status(2);

                if (livro.getId_livro() == 0)
                {
                    livroSQL.incluir(livro);
                    MessageBox.Show("Livro Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos(this);
                }
                else
                {
                    livroSQL.atualizar(livro);
                    MessageBox.Show("Livro Atualizado com Sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FormAddEditLivro_FormClosing(object sender, FormClosingEventArgs e)
        {
            livroSQL.getLivro(dgvLivro);
        }
    }
}
