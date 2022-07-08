using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using estanteTech.Modelo;
using estanteTech.SQL;

namespace estanteTech.Forms.FormDevolucao
{
    public partial class FormLivroDevolucao : Form
    {
        Emprestimo emprestimo = new Emprestimo();
        DevolucaoSQL devolucaoSQL = new DevolucaoSQL();

        public FormLivroDevolucao()
        {
            InitializeComponent();
            devolucaoSQL.getLivro(dgvDevolucao);
        }

        private void dgvDevolucao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvDevolucao.Rows[e.RowIndex].Cells["fazDevolucao"].ToolTipText = "Clique aqui para devolver";
        }

        private void dgvDevolucao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            emprestimo.setId_livro(Convert.ToInt32(dgvDevolucao.Rows[e.RowIndex].Cells["id_livro"].Value.ToString()));

            if (dgvDevolucao.Columns[e.ColumnIndex] == dgvDevolucao.Columns["fazDevolucao"])
            {
                DialogResult result = MessageBox.Show("Deseja realizar a devolução?", "Confirmar devolução!"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    devolucaoSQL.devolveLivro(emprestimo);
                    MessageBox.Show("Livro Devolvido com Sucesso!", "Devolução", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    devolucaoSQL.getLivro(dgvDevolucao);
                }
            }
        }

        private void dgvDevolucao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvDevolucao.Columns)
            {
                switch (coluna.Name)
                {
                    case "nome":
                        coluna.HeaderText = "Leitor";
                        break;
                    case "titulo":
                        coluna.HeaderText = "Título";
                        break;
                    case "genero":
                        coluna.HeaderText = "Gênero";
                        break;
                    case "data_emprestimo":
                        coluna.HeaderText = "Data Empréstimo";
                        break;
                    case "data_devolucao":
                        coluna.HeaderText = "Data Devolução";
                        break;
                    case "fazDevolucao":
                        //Altera a posiçao na tabela
                        coluna.DisplayIndex = 7;
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

            devolucaoSQL.pesquisar(texto, dgvDevolucao);
        }
    }
}
