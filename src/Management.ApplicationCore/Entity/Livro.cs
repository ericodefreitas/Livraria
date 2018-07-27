using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.ApplicationCore.Entity
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Subtitulo { get; set; }

        public byte Edicao { get; set; }

        public int Ano { get; set; }

        public int Paginas { get; set; }

        public double Preco { get; set; }

        public string Editora { get; set; }

        public byte Idioma { get; set; }
    }
}
