using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Livraria.ApplicationCore.Interfaces
{
    public interface IRepository<Tentity> where Tentity : class
    {
        Tentity Adicionar(Tentity entity);

        void Atualizar(Tentity entity);

        IEnumerable<Tentity> ObterTodos();

        Tentity ObterPorId(int id);

        IEnumerable<Tentity> Buscar(Expression<Func<Tentity, bool>> predicado);

        void Remover(Tentity entity);
    }
}
