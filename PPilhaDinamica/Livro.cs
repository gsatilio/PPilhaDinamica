using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilhaDinamica
{
    internal class Livro
    {
        string titulo;
        Livro anterior;

        public Livro(string titulo)
        {
            this.titulo = titulo;
            this.anterior = null;
        }

        public override string? ToString()
        {
            return "\nTítulo do Livro: " + titulo;
        }

        public void setAnterior(Livro livro)
        {
            anterior = livro;
        }
        public Livro getAnterior()
        {
            return anterior;
        }
        public string getTitulo()
        {
            return titulo;
        }
    }
}
