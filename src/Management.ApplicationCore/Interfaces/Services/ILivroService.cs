using Livraria.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Livraria.ApplicationCore.Interfaces
{
    public interface ILivroService
    {
        Livro Adicionar(Livro entity);

        Livro Atualizar(Livro entity);

        IEnumerable<Livro> ObterTodos();

        IEnumerable<Livro> ObterTodosOrdenadosPorNome();

        Livro ObterPorId(int id);

        IEnumerable<Livro> Buscar(Expression<Func<Livro, bool>> predicado);

        void Remover(int id);
    }
}
