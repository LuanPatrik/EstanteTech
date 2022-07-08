using estanteTech.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace estanteTech.SQL
{
	public class LivroSQL : conexao
	{
		
		public void incluir(Livro livro)
		{
			abrirConexao();
			String sql = "INSERT INTO livro (titulo, editora, edicao, ano_publicacao, autor, genero, idioma, " +
				"qt_pagina, codigo_isbn, id_status) VALUES (@titulo, @editora, @edicao, @ano_publicacao, @autor, @genero, @idioma, " +
				"@qt_pagina, @codigo_isbn, @id_status);";

			try 
			{
				MySqlCommand command = new MySqlCommand(sql, con);
				command.Parameters.AddWithValue("@titulo", livro.getTitulo());
				command.Parameters.AddWithValue("@editora", livro.getEditora());
				command.Parameters.AddWithValue("@edicao", livro.getEdicao());
				command.Parameters.AddWithValue("@ano_publicacao", livro.getAno_publicacao());
				command.Parameters.AddWithValue("@autor", livro.getAutor());
				command.Parameters.AddWithValue("@genero", livro.getGenero());
				command.Parameters.AddWithValue("@idioma", livro.getIdioma());
				command.Parameters.AddWithValue("@qt_pagina", livro.getQt_pagina());
				command.Parameters.AddWithValue("@codigo_isbn", livro.getCod_ISBN());
				command.Parameters.AddWithValue("@id_status", livro.getId_status());

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

		public void atualizar(Livro livro)
        {
			abrirConexao();
			String sql = "UPDATE livro SET titulo = @titulo, editora = @editora, edicao = @edicao, ano_publicacao = @ano_publicacao, autor = @autor, " +
				"genero = @genero, idioma = @idioma, qt_pagina = @qt_pagina, codigo_isbn = @codigo_isbn, id_status = @id_status " +
				"WHERE id_livro = @id_livro;";

            try
            {
				MySqlCommand command = new MySqlCommand(sql, con);
				command.Parameters.AddWithValue("@titulo", livro.getTitulo());
				command.Parameters.AddWithValue("@editora", livro.getEditora());
				command.Parameters.AddWithValue("@edicao", livro.getEdicao());
				command.Parameters.AddWithValue("@ano_publicacao", livro.getAno_publicacao());
				command.Parameters.AddWithValue("@autor", livro.getAutor());
				command.Parameters.AddWithValue("@genero", livro.getGenero());
				command.Parameters.AddWithValue("@idioma", livro.getIdioma());
				command.Parameters.AddWithValue("@qt_pagina", livro.getQt_pagina());
				command.Parameters.AddWithValue("@codigo_isbn", livro.getCod_ISBN());
				command.Parameters.AddWithValue("@id_status", livro.getId_status());
				command.Parameters.AddWithValue("@id_livro", livro.getId_livro());

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

		public void excluir(Livro livro)
        {
			abrirConexao();
			String sql = "DELETE FROM livro WHERE id_livro = @id_livro;";

            try
            {
				MySqlCommand commad = new MySqlCommand(sql, con);
				commad.Parameters.AddWithValue("@id_livro", livro.getId_livro());

				commad.ExecuteNonQuery();
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

		public void getLivro(DataGridView dgv)
        {
			abrirConexao();
			String sql = "SELECT id_livro ,titulo, editora, edicao, ano_publicacao, autor, " +
				"genero, idioma, qt_pagina, codigo_isbn FROM livro;";

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
			String sql = "SELECT id_livro ,titulo, editora, edicao, ano_publicacao, autor, " +
				"genero, idioma, qt_pagina, codigo_isbn FROM livro " +
				"WHERE titulo LIKE '%" + texto + "%' OR editora LIKE '%" + texto + "%' OR edicao LIKE '%" + texto + "%' " +
				"OR ano_publicacao LIKE '%" + texto + "%' OR autor LIKE '%" + texto + "%' OR genero LIKE '%" + texto + "%' " +
				"OR idioma LIKE '%" + texto + "%' OR qt_pagina LIKE '%" + texto + "%' OR codigo_isbn LIKE '%" + texto + "%';";

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
