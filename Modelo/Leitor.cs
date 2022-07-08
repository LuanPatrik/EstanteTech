using System;
using System.Collections.Generic;
using System.Text;

namespace estanteTech.Modelo
{
    public class Leitor
    {
        private int id_leitor;
        private String nome;
        private double numero_ra;
        private DateTime data_nasc;
        private String email;
        private double telefone;

        public int getId_leitor()
        {
            return id_leitor;
        }

        public void setId_leitor(int id_leitor)
        {
            this.id_leitor = id_leitor;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public double getNumero_ra()
        {
            return numero_ra;
        }

        public void setNumero_ra(double numero_ra)
        {
            this.numero_ra = numero_ra;
        }

        public DateTime getData_nasc()
        {
            return data_nasc;
        }

        public void setData_nasc(DateTime data_nasc)
        {
            this.data_nasc = data_nasc;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public double getTelefone()
        {
            return telefone;
        }

        public void setTelefone(double telefone)
        {
            this.telefone = telefone;
        }
    }
}
