using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using estanteTech.Forms.FormEmprestimo;
using estanteTech.Modelo;
using estanteTech.SQL;

namespace estanteTech.Forms.FormEmprestimo
{
    public partial class FormLivroEmprestimo : Form
    {
        EmprestimoSQL emprestimoSQL = new EmprestimoSQL();
        Emprestimo emprestimo = new Emprestimo();

        public FormLivroEmprestimo()
        {
            InitializeComponent();
            emprestimoSQL.getLivro(dgvEmprestimo);
        }

        public FormLivroEmprestimo(int id)
        {
            InitializeComponent();
            emprestimoSQL.getLivro(dgvEmprestimo);
            emprestimo.setId_funcionario(id);
        }

        private void dgvEmprestimo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvEmprestimo.Rows[e.RowIndex].Cells["fazEmprestimo"].ToolTipText = "Clique aqui para emprestar";
        }

        private void dgvEmprestimo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            emprestimo.setId_livro(Convert.ToInt32(dgvEmprestimo.Rows[e.RowIndex].Cells["id_livro"].Value.ToString()));

            if (dgvEmprestimo.Columns[e.ColumnIndex] == dgvEmprestimo.Columns["fazEmprestimo"])
            {
                FormEmprestimo form = new FormEmprestimo(emprestimo.getId_livro(), emprestimo.getId_funcionario(), dgvEmprestimo);
                form.Show();
            }
        }

        private void dgvEmprestimo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvEmprestimo.Columns)
            {
                switch (coluna.Name)
                {
                    case "titulo":
                        coluna.HeaderText = "Título";
                        break;
                    case "editora":
                        coluna.HeaderText = "Editora";
                        break;
                    case "edicao":
                        coluna.HeaderText = "Edição";
                        break;
                    case "ano_publicacao":
                        coluna.HeaderText = "Ano Publicação";
                        break;
                    case "autor":
                        coluna.HeaderText = "Autor(es)";
                        break;
                    case "genero":
                        coluna.HeaderText = "Gênero";
                        break;
                    case "idioma":
                        coluna.HeaderText = "Idioma";
                        break;
                    case "qt_pagina":
                        coluna.HeaderText = "Quantidade Páginas";
                        break;
                    case "codigo_isbn":
                        coluna.HeaderText = "Código ISBN";
                        break;
                    case "fazEmprestimo":
                        //Altera a posiçao na tabela
                        coluna.DisplayIndex = 10;
                        break;
                    default:
                        //Ocultar a coluna Id
                        coluna.Visible = false;
                        break;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String texto = tbPesquisar.Text;

            emprestimoSQL.pesquisar(texto, dgvEmprestimo);
        }
    }
}
