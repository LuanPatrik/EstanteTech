using estanteTech.Modelo;
using estanteTech.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace estanteTech.Forms.FormLivro
{
    public partial class FormCadastroLivro : Form
    {
        Livro livro = new Livro();
        LivroSQL livroSQL = new LivroSQL();

        public FormCadastroLivro()
        {
            InitializeComponent();
            livroSQL.getLivro(dgvLivro);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormAddEditLivro form = new FormAddEditLivro(dgvLivro);
            form.Show();
        }

        private void dgvLivro_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvLivro.Columns)
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
                    case "adicionar":
                        //Altera a posiçao na tabela
                        coluna.DisplayIndex = 10;
                        break;
                    case "editar":
                        //Altera a posiçao na tabela
                        coluna.DisplayIndex = 11;
                        break;
                    case "excluir":
                        coluna.DisplayIndex = 12;
                        break;
                    default:
                        //Ocultar a coluna Id
                        coluna.Visible = false;
                        break;
                }
            }
        }

        private void dgvLivro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Adicionar ToolTip nas imagens da DataGriedView
            dgvLivro.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvLivro.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
            dgvLivro.Rows[e.RowIndex].Cells["adicionar"].ToolTipText = "Clique aqui para adicionar";
        }

        private void dgvLivro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar id 
            livro.setId_livro(Convert.ToInt32(dgvLivro.Rows[e.RowIndex].Cells["id_livro"].Value.ToString()));

            if (dgvLivro.Columns[e.ColumnIndex] == dgvLivro.Columns["editar"])
            {
                livro.setTitulo(dgvLivro.Rows[e.RowIndex].Cells["titulo"].Value.ToString());
                livro.setEditora(dgvLivro.Rows[e.RowIndex].Cells["editora"].Value.ToString());
                livro.setEdicao(dgvLivro.Rows[e.RowIndex].Cells["edicao"].Value.ToString());
                livro.setAno_publicacao(Convert.ToInt32(dgvLivro.Rows[e.RowIndex].Cells["ano_publicacao"].Value.ToString()));
                livro.setAutor(dgvLivro.Rows[e.RowIndex].Cells["autor"].Value.ToString());
                livro.setGenero(dgvLivro.Rows[e.RowIndex].Cells["genero"].Value.ToString());
                livro.setIdioma(dgvLivro.Rows[e.RowIndex].Cells["idioma"].Value.ToString());
                livro.setQt_pagina(Convert.ToInt32(dgvLivro.Rows[e.RowIndex].Cells["qt_pagina"].Value.ToString()));
                livro.setCod_ISBN(dgvLivro.Rows[e.RowIndex].Cells["codigo_isbn"].Value.ToString());
                livro.setId_status(2);

                FormAddEditLivro form = new FormAddEditLivro(livro, dgvLivro);
                form.Show();
            }

            if (dgvLivro.Columns[e.ColumnIndex] == dgvLivro.Columns["excluir"])
            {
                DialogResult result = MessageBox.Show("Deseja excluir o livro?", "Confirmar Exclusão!"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    livroSQL.excluir(livro);
                    MessageBox.Show("Livro excluído com sucesso!", "Exclusão");
                    livroSQL.getLivro(dgvLivro);
                }
            }

            if (dgvLivro.Columns[e.ColumnIndex] == dgvLivro.Columns["adicionar"])
            {
                livro.setId_livro(0);
                livro.setTitulo(dgvLivro.Rows[e.RowIndex].Cells["titulo"].Value.ToString());
                livro.setEditora(dgvLivro.Rows[e.RowIndex].Cells["editora"].Value.ToString());
                livro.setEdicao(dgvLivro.Rows[e.RowIndex].Cells["edicao"].Value.ToString());
                livro.setAno_publicacao(Convert.ToInt32(dgvLivro.Rows[e.RowIndex].Cells["ano_publicacao"].Value.ToString()));
                livro.setAutor(dgvLivro.Rows[e.RowIndex].Cells["autor"].Value.ToString());
                livro.setGenero(dgvLivro.Rows[e.RowIndex].Cells["genero"].Value.ToString());
                livro.setIdioma(dgvLivro.Rows[e.RowIndex].Cells["idioma"].Value.ToString());
                livro.setQt_pagina(Convert.ToInt32(dgvLivro.Rows[e.RowIndex].Cells["qt_pagina"].Value.ToString()));
                livro.setCod_ISBN(dgvLivro.Rows[e.RowIndex].Cells["codigo_isbn"].Value.ToString());
                livro.setId_status(2);

                FormAddEditLivro form = new FormAddEditLivro(livro, dgvLivro);
                form.Show();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String texto = tbPesquisar.Text;

            livroSQL.pesquisar(texto, dgvLivro);
        }
    }
}
