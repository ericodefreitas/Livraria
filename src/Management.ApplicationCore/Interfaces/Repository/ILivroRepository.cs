using Livraria.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.ApplicationCore.Interfaces
{
    public interface ILivroRepository: IRepository<Livro>
    {
        IEnumerable<Livro> ObterTodosOrdenadosPorNome();
    }
}
