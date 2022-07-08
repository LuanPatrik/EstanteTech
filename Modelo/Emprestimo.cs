using System;
using System.Collections.Generic;
using System.Text;

namespace estanteTech.Modelo
{
    public class Emprestimo
    {
        private int id_emprestimo;
        private DateTime data_emprestimo;
        private DateTime data_devolucao;
        private int id_livro;
        private int id_funcionario;
        private int id_leitor;
        private int id_status;

        public int getId_emprestimo()
        {
            return id_emprestimo;
        }

        public void setId_emprestimo(int id_emprestimo)
        {
            this.id_emprestimo = id_emprestimo;
        }

        public DateTime getData_emprestimo()
        {
            return data_emprestimo;
        }

        public void SetData_emprestimo(DateTime data_emprestimo)
        {
            this.data_emprestimo = data_emprestimo;
        }

        public DateTime getData_devolucao()
        {
            return data_devolucao;
        }

        public void setData_devolucao(DateTime data_devolucao)
        {
            this.data_devolucao = data_devolucao;
        }

        public int getId_livro()
        {
            return id_livro;
        }

        public void setId_livro(int id_livro)
        {
            this.id_livro = id_livro;
        }

        public int getId_funcionario()
        {
            return id_funcionario;
        }

        public void setId_funcionario(int id_funcionario)
        {
            this.id_funcionario = id_funcionario;
        }

        public int getId_leitor()
        {
            return id_leitor;
        }

        public void setId_leitor(int id_leitor)
        {
            this.id_leitor = id_leitor;
        }

        public int getId_status()
        {
            return id_status;
        }

        public void setId_status(int id_status)
        {
            this.id_status = id_status;
        }
    }
}
