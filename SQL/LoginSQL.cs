using estanteTech.Modelo;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace estanteTech.SQL
{
    public class LoginSQL : conexao
    {
        public int verificaID(String usuario, String senha)
        {
            abrirConexao();
            String sql = "SELECT id_funcionario FROM funcionario WHERE usuario = @usuario AND senha = @senha;";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@senha", senha);

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

        public int credencial(int id)
        {
            abrirConexao();
            String sql = "SELECT tipo_usuario FROM funcionario WHERE id_funcionario = @id;";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@id", id);

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
