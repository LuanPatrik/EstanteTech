using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using estanteTech.Modelo;
using System.Threading.Tasks;
using System.Data;
using estanteTech.FormFuncionario;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using Microsoft.TeamFoundation.Build.WebApi;

namespace estanteTech.SQL
{
    public class FuncionarioSQL : conexao
    {
        public int incluir(Funcionario funcionario)
        {
            abrirConexao();

            String sql = "INSERT INTO funcionario (nome, email, telefone, usuario, senha, tipo_usuario) VALUES (@nome, @email, @telefone, @usuario, @senha, @tipo_usuario)";
            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@nome", funcionario.getNome());
                command.Parameters.AddWithValue("@email", funcionario.getEmail());
                command.Parameters.AddWithValue("@telefone", funcionario.getTelefone());
                command.Parameters.AddWithValue("@usuario", funcionario.getUsuario());
                command.Parameters.AddWithValue("@senha", funcionario.getSenha());
                command.Parameters.AddWithValue("@tipo_usuario", funcionario.getTipo_usuario());

                command.ExecuteNonQuery();

                return 1;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public int atualziar(Funcionario funcionario)
        {
            abrirConexao();

            String sql = "UPDATE funcionario SET  nome = @nome, email = @email, telefone = @telefone, usuario = @usuario, senha = @senha, tipo_usuario = @tipo_usuario" +
                " WHERE id_funcionario = @id_funcionario";
            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@nome", funcionario.getNome());
                command.Parameters.AddWithValue("@email", funcionario.getEmail());
                command.Parameters.AddWithValue("@telefone", funcionario.getTelefone());
                command.Parameters.AddWithValue("@usuario", funcionario.getUsuario());
                command.Parameters.AddWithValue("@senha", funcionario.getSenha());
                command.Parameters.AddWithValue("@tipo_usuario", funcionario.getTipo_usuario());
                command.Parameters.AddWithValue("@id_funcionario", funcionario.getId_funcionario());

                command.ExecuteNonQuery();

                return 2;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void excluir(Funcionario funcionario)
        {
            abrirConexao();

            String sql = "DELETE FROM funcionario WHERE id_funcionario = @id_funcionario";
            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@id_funcionario", funcionario.getId_funcionario());

                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void getFuncionario(DataGridView dgv)
        {
            abrirConexao();
            Funcionario func = new Funcionario();

            String sql = "SELECT f.id_funcionario, f.nome, f.email, f.telefone, f.usuario, f.senha, tu.descricao FROM funcionario as f " +
                "JOIN tipo_usuario AS tu ON tu.id_tipo_usuario = f.tipo_usuario";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                MySqlDataReader dados = command.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados); //Carrega os dados para o datatable
                    dgv.DataSource = dt; //Preenche a DataGridView
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void pesquisaFuncionario(DataGridView dgv, string texto)
        {
            abrirConexao();

            String sql = "SELECT f.id_funcionario, f.nome, f.email, f.telefone, f.usuario, f.senha, tu.descricao FROM funcionario as f " +
                "JOIN tipo_usuario AS tu ON tu.id_tipo_usuario = f.tipo_usuario " +
                "WHERE f.nome LIKE '%" + texto + "%' OR f.email LIKE '%" + texto + "%' OR f.telefone LIKE '%" + texto + "%'" +
                " OR f.usuario LIKE '%" + texto + "%' OR tu.descricao LIKE '%" + texto + "%';";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                MySqlDataReader dados = command.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados); //Carrega os dados para o datatable
                    dgv.DataSource = dt; //Preenche a DataGridView
                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado!");
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public int verificaUsuarioExistente(String usuario)
        {
            abrirConexao();

            String sql = "SELECT id_funcionario FROM funcionario WHERE usuario = @usuario;";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@usuario", usuario);

                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    return dr.GetInt32(0);
                }

                return 0;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
