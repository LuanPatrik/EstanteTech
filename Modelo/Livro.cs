using System;
using System.Collections.Generic;
using System.Text;

namespace estanteTech.Modelo
{
    public class Livro
    {
        private int id_livro;
        private String titulo;
        private String edicao;
        private String autor;
        private double ano_publicacao;
        private String genero;
        private String idioma;
        private double qt_pagina;
        private String cod_ISBN;
        private String editora;
        private int id_status;

        public int getId_livro()
        {
            return id_livro;
        }

        public void setId_livro(int id_livro)
        {
            this.id_livro = id_livro;
        }

        public String getTitulo()
        {
            return titulo;
        }

        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }

        public String getEdicao()
        {
            return edicao;
        }

        public void setEdicao(String edicao)
        {
            this.edicao = edicao;
        }

        public String getAutor()
        {
            return autor;
        }

        public void setAutor(String autor)
        {
            this.autor = autor;
        }

        public double getAno_publicacao()
        {
            return ano_publicacao;
        }

        public void setAno_publicacao(double ano_publicacao)
        {
            this.ano_publicacao = ano_publicacao;
        }

        public String getGenero()
        {
            return genero;
        }

        public void setGenero(String genero)
        {
            this.genero = genero;
        }

        public String getIdioma()
        {
            return idioma;
        }

        public void setIdioma(String idioma)
        {
            this.idioma = idioma;
        }

        public double getQt_pagina()
        {
            return qt_pagina;
        }

        public void setQt_pagina(double qt_pagina)
        {
            this.qt_pagina = qt_pagina;
        }

        public String getCod_ISBN()
        {
            return cod_ISBN;
        }

        public void setCod_ISBN(String cod_ISBN)
        {
            this.cod_ISBN = cod_ISBN;
        }

        public int getId_status()
        {
            return id_status;
        }

        public void setId_status(int id_status)
        {
            this.id_status = id_status;
        }

        public String getEditora()
        {
            return editora;
        }

        public void setEditora(String editora)
        {
            this.editora = editora;
        }
    }
}
