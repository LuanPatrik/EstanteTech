using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using estanteTech.Modelo;
using estanteTech.SQL;
using estanteTech.Forms;

namespace estanteTech.FormFuncionario
{
    public partial class FormCadastroFunc : Form
    {
        FuncionarioSQL funcionarioSQL = new FuncionarioSQL();
        Funcionario funcionario = new Funcionario();

        public FormCadastroFunc()
        {
            InitializeComponent();
            funcionarioSQL.getFuncionario(dgvFuncionario);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormAddEditFunc form = new FormAddEditFunc(dgvFuncionario);
            form.Show();
        }

        private void dgvFuncionario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Aumentar o tamanho das colunas
            foreach (DataGridViewColumn coluna in dgvFuncionario.Columns)
            {
                switch (coluna.Name)
                {
                    case "nome":
                        coluna.HeaderText = "Nome";
                        break;
                    case "email":
                        coluna.HeaderText = "Email";
                        break;
                    case "telefone":
                        coluna.HeaderText = "Telefone";
                        break;
                    case "usuario":
                        coluna.HeaderText = "Usuário";
                        break;
                    case "senha":
                        coluna.HeaderText = "Senha";
                        break;
                    case "descricao":
                        coluna.HeaderText = "Tipo Usuário";
                        break;
                    case "editar":
                        //Altera a posiçao na tabela
                        coluna.DisplayIndex = 7;
                        break;
                    case "excluir":
                        coluna.DisplayIndex = 8;
                        break;
                    default:
                        //Ocultar a coluna Id
                        coluna.Visible = false;
                        break;
                }
            }
        }

        private void dgvFuncionario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Adicionar ToolTip nas imagens da DataGriedView
            dgvFuncionario.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvFuncionario.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar id 
            funcionario.setId_funcionario(Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["id_funcionario"].Value.ToString()));

            if (dgvFuncionario.Columns[e.ColumnIndex] == dgvFuncionario.Columns["editar"])
            {
                funcionario.setNome(dgvFuncionario.Rows[e.RowIndex].Cells["nome"].Value.ToString());
                funcionario.setEmail(dgvFuncionario.Rows[e.RowIndex].Cells["email"].Value.ToString());
                funcionario.setTelefone(Convert.ToInt64(dgvFuncionario.Rows[e.RowIndex].Cells["telefone"].Value.ToString()));
                funcionario.setUsuario(dgvFuncionario.Rows[e.RowIndex].Cells["usuario"].Value.ToString());
                funcionario.setSenha(dgvFuncionario.Rows[e.RowIndex].Cells["senha"].Value.ToString());

                if (dgvFuncionario.Rows[e.RowIndex].Cells["descricao"].Value.ToString() == "Administrador")
                {
                    funcionario.setTipo_usuario(0);
                }
                else
                {
                    funcionario.setTipo_usuario(1);
                }

                FormAddEditFunc form = new FormAddEditFunc(funcionario, dgvFuncionario);
                form.Show();
            }

            if (dgvFuncionario.Columns[e.ColumnIndex] == dgvFuncionario.Columns["excluir"])
            {
                DialogResult result = MessageBox.Show("Deseja excluir o funcionário?", "Confirmar Exclusão!"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    funcionarioSQL.excluir(funcionario);
                    MessageBox.Show("Funcionario excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funcionarioSQL.getFuncionario(dgvFuncionario);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string texto = tbPesquisar.Text;

            funcionarioSQL.pesquisaFuncionario(dgvFuncionario, texto);
        }
    }
}
