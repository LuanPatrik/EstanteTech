using estanteTech.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace estanteTech.SQL
{
    public class EmprestimoSQL : conexao
    {
        public void incluir(Emprestimo emprestimo)
        {
            abrirConexao();
            String sql = "INSERT INTO emprestimo (data_emprestimo, data_devolucao, id_status, id_livro, id_leitor, id_funcionario) " +
                "VALUES (@data_emprestimo, @data_devolucao, @id_status, @id_livro, @id_leitor, @id_funcionario);";

            String sqlUpdate = "UPDATE livro SET id_status = 1 WHERE id_livro = @id_livro;";

            try
            {
                MySqlCommand command = new MySqlCommand(sql,con);
                command.Parameters.AddWithValue("@data_emprestimo", emprestimo.getData_emprestimo());
                command.Parameters.AddWithValue("@data_devolucao", emprestimo.getData_devolucao());
                command.Parameters.AddWithValue("@id_status", emprestimo.getId_status());
                command.Parameters.AddWithValue("@id_livro", emprestimo.getId_livro());
                command.Parameters.AddWithValue("@id_leitor", emprestimo.getId_leitor());
                command.Parameters.AddWithValue("@id_funcionario", emprestimo.getId_funcionario());

                command.ExecuteNonQuery();

                MySqlCommand cmd = new MySqlCommand(sqlUpdate, con);
                cmd.Parameters.AddWithValue("@id_livro", emprestimo.getId_livro());
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
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
            String sql = "SELECT id_livro ,titulo, editora, edicao, ano_publicacao, autor, " +
                "genero, idioma, qt_pagina, codigo_isbn FROM livro WHERE id_status = 2;";

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

        public void listaLeitor(ComboBox cbx, string texto)
        {
            abrirConexao();
            String sql = "SELECT id_leitor, nome FROM leitor WHERE nome LIKE '%" + texto + "%';";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                MySqlDataReader dados = command.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    cbx.DisplayMember = "nome";
                    cbx.ValueMember = "id_leitor";
                    cbx.DataSource = dt;
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
            String sql = "SELECT id_livro ,titulo, editora, edicao, ano_publicacao, autor, " +
                "genero, idioma, qt_pagina, codigo_isbn FROM livro " +
                "WHERE id_status = 2 AND (titulo LIKE '%" + texto + "%' OR editora LIKE '%" + texto + "%' OR edicao LIKE '%" + texto + "%' " +
                "OR ano_publicacao LIKE '%" + texto + "%' OR autor LIKE '%" + texto + "%' OR genero LIKE '%" + texto + "%' " +
                "OR idioma LIKE '%" + texto + "%' OR qt_pagina LIKE '%" + texto + "%' OR codigo_isbn LIKE '%" + texto + "%');";

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
