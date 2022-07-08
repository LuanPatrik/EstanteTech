using System;
using System.Collections.Generic;
using System.Text;

namespace estanteTech.Modelo
{
    public class Funcionario
    {
        private int id_funcionario;
        private String nome;
        private String email;
        private Double telefone;
        private String usuario;
        private String senha;
        private int tipo_usuario;

        public int getId_funcionario()
        {
            return id_funcionario;
        }

        public void setId_funcionario(int id_funcionario)
        {
            this.id_funcionario = id_funcionario;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public Double getTelefone()
        {
            return telefone;
        }
        public void setTelefone(Double telefone)
        {
            this.telefone = telefone;
        }

        public String getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getUsuario()
        {
            return usuario;
        }

        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }
        public String getSenha()
        {
            return senha;
        }

        public void setSenha(String senha)
        {
            this.senha = senha;
        }

        public int getTipo_usuario()
        {
            return tipo_usuario;
        }

        public void setTipo_usuario(int tipo_usuario)
        {
            this.tipo_usuario = tipo_usuario;
        }
    }
}
