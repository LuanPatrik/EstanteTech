using estanteTech.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace estanteTech.SQL
{
    public class DevolucaoSQL : conexao
    {
        public void devolveLivro(Emprestimo emprestimo)
        {
            abrirConexao();
            String sql = "UPDATE livro SET id_status = 2 WHERE id_livro = @id_livro;";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@id_livro", emprestimo.getId_livro());

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public void getLivro(DataGridView dgv)
        {
            abrirConexao();
            String sql = "SELECT l.id_livro, le.id_leitor, le.nome, l.titulo, l.genero, e.data_emprestimo, e.data_devolucao FROM livro AS l " +
                           "JOIN emprestimo AS e ON e.id_livro = l.id_livro " +
                            "JOIN leitor AS le ON le.id_leitor = e.id_leitor " +
                            "WHERE l.id_status = 1;";

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
            catch (MySqlException ex)
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
            String sql = "SELECT l.id_livro, le.id_leitor, le.nome, l.titulo, l.genero, e.data_emprestimo, e.data_devolucao FROM livro AS l " +
                "JOIN emprestimo AS e ON e.id_livro = l.id_livro " +
                "JOIN leitor AS le ON le.id_leitor = e.id_leitor " +
                "WHERE l.id_status = 1 AND (le.nome LIKE '%" + texto + "%' OR l.titulo LIKE '%" + texto + "%' OR l.genero LIKE '%" + texto + "%' " +
                "OR e.data_emprestimo LIKE '%" + texto + "%' OR e.data_devolucao LIKE '%" + texto +"%');";

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
