using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace estanteTech.SQL
{
    public class conexao
    {
        public string connection = "server=localhost; database=estanteTech; uid=root; password=; port=3306;";
        public MySqlConnection con = null;

        public void abrirConexao()
        {
            try
            {
                con = new MySqlConnection(connection);
                con.Open();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void fecharConexao()
        {
            try
            {
                con = new MySqlConnection(connection);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
