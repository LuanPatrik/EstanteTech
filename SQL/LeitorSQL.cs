using System;
using System.Collections.Generic;
using System.Text;
using estanteTech.Modelo;
using MySql.Data.MySqlClient;
using estanteTech.Forms;
using System.Windows.Forms;
using System.Data;

namespace estanteTech.SQL
{
    public class LeitorSQL : conexao
    {
        public void incluir(Leitor leitor)
        {
            abrirConexao();
            String sql = "INSERT INTO leitor (nome, data_nasc, telefone, numero_ra, email) VALUES (@nome, @data_nasc, @telefone, @numero_ra, @email);";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@nome", leitor.getNome());
                command.Parameters.AddWithValue("@data_nasc", leitor.getData_nasc());
                command.Parameters.AddWithValue("@telefone", leitor.getTelefone());
                command.Parameters.AddWithValue("@numero_ra", leitor.getNumero_ra());
                command.Parameters.AddWithValue("@email", leitor.getEmail());

                command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void atualizar(Leitor leitor)
        {
            abrirConexao();
            String sql = "UPDATE leitor SET nome = @nome, data_nasc = @data_nasc, telefone = @telefone, " +
                "numero_ra = @numero_ra, email = @email WHERE id_leitor = @id_leitor";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@nome", leitor.getNome());
                command.Parameters.AddWithValue("@data_nasc", leitor.getData_nasc());
                command.Parameters.AddWithValue("@telefone", leitor.getTelefone());
                command.Parameters.AddWithValue("@numero_ra", leitor.getNumero_ra());
                command.Parameters.AddWithValue("@email", leitor.getEmail());
                command.Parameters.AddWithValue("@id_leitor", leitor.getId_leitor());

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

        public void excluir(Leitor leitor)
        {
            abrirConexao();
            String sql = "DELETE FROM leitor WHERE id_leitor = @id_leitor;";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@id_leitor", leitor.getId_leitor());

                command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void getLeitor(DataGridView dgv)
        {
            abrirConexao();

            String sql = "SELECT * FROM leitor;";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                MySqlDataReader dados = command.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    dgv.DataSource = dt;
                }
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void pesquisar(String texto, DataGridView dgv)
        {
            abrirConexao();
            String sql = "SELECT * FROM leitor " +
                "WHERE nome LIKE '%" + texto + "%' OR numero_ra LIKE '%" + texto + "%' OR data_nasc LIKE '%" + texto + "%' " +
                "OR email LIKE '%" + texto + "%' OR telefone LIKE '%" + texto + "%';";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                MySqlDataReader dados = command.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    dgv.DataSource = dt;
                }
            }
            catch(MySqlException ex)
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
