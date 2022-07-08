using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using estanteTech.SQL;
using estanteTech.Modelo;
using estanteTech.Forms.Formleitor;

namespace estanteTech.Forms.Formleitor
{
    public partial class FormCadastroLeitor : Form
    {
        LeitorSQL leitorSQL = new LeitorSQL();
        Leitor leitor = new Leitor();
        int tipo_usuario;

        public FormCadastroLeitor(int tipo_usuario)
        {
            InitializeComponent();
            leitorSQL.getLeitor(dgvLeitor);
            this.tipo_usuario = tipo_usuario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormAddEditLeitor form = new FormAddEditLeitor(dgvLeitor);
            form.Show();
        }

        private void dgvLeitor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvLeitor.Columns)
            {
                switch(coluna.Name)
                {
                    case "nome":
                        coluna.HeaderText = "Nome";
                        break;
                    case "data_nasc":
                        coluna.HeaderText = "Data Nascimento";
                        break;
                    case "telefone":
                        coluna.HeaderText = "Telefone";
                        break;
                    case "numero_ra":
                        coluna.HeaderText = "Número RA";
                        break;
                    case "email":
                        coluna.HeaderText = "Email";
                        break;
                    case "editar":
                        //Altera a posiçao na tabela
                        coluna.DisplayIndex = 6;
                        break;
                    case "excluir":
                        coluna.DisplayIndex = 7;
                        break;
                    default:
                        //Ocultar a coluna Id
                        coluna.Visible = false;
                        break;
                }
            }

            if (tipo_usuario == 2)
            {
                dgvLeitor.Columns["excluir"].Visible = false;
            }
        }

        private void dgvLeitor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Adicionar ToolTip nas imagens da DataGriedView
            dgvLeitor.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvLeitor.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }

        private void dgvLeitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar id 
            leitor.setId_leitor(Convert.ToInt32(dgvLeitor.Rows[e.RowIndex].Cells["id_leitor"].Value.ToString()));
            
            if (dgvLeitor.Columns[e.ColumnIndex] == dgvLeitor.Columns["editar"])
            {
                leitor.setNome(dgvLeitor.Rows[e.RowIndex].Cells["nome"].Value.ToString());
                leitor.setEmail(dgvLeitor.Rows[e.RowIndex].Cells["email"].Value.ToString());
                leitor.setTelefone(Convert.ToInt64(dgvLeitor.Rows[e.RowIndex].Cells["telefone"].Value.ToString()));
                leitor.setData_nasc(Convert.ToDateTime(dgvLeitor.Rows[e.RowIndex].Cells["data_nasc"].Value.ToString()));
                leitor.setNumero_ra(Convert.ToDouble(dgvLeitor.Rows[e.RowIndex].Cells["numero_ra"].Value.ToString()));

                FormAddEditLeitor form = new FormAddEditLeitor(leitor, dgvLeitor);
                form.Show();
            }

            if (dgvLeitor.Columns[e.ColumnIndex] == dgvLeitor.Columns["excluir"])
            {
                DialogResult result = MessageBox.Show("Deseja excluir o leitor?", "Confirmar Exclusão!"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    leitorSQL.excluir(leitor);
                    MessageBox.Show("Leitor excluído com sucesso!", "Exclusão");
                    leitorSQL.getLeitor(dgvLeitor);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String texto = tbPesquisar.Text;
            leitorSQL.pesquisar(texto, dgvLeitor);
        }
    }
}
