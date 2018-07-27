using Livraria.ApplicationCore.Entity;
using Livraria.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Livraria.ApplicationCore.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        #region Methods

        public Livro Adicionar(Livro entity)
        {
            return _livroRepository.Adicionar(entity);
        }

        public Livro Atualizar(Livro entity)
        {
            return _livroRepository.Atualizar(entity);
        }

        public IEnumerable<Livro> Buscar(Expression<Func<Livro, bool>> predicado)
        {
            return _livroRepository.Buscar(predicado);
        }

        public Livro ObterPorId(int id)
        {
            return _livroRepository.ObterPorId(id);
        }

        public IEnumerable<Livro> ObterTodos()
        {
            return _livroRepository.ObterTodos();
        }

        public IEnumerable<Livro> ObterTodosOrdenadosPorNome()
        {
            return _livroRepository.ObterTodosOrdenadosPorNome();
        }

        public void Remover(Livro entity)
        {
            _livroRepository.Remover(entity);
        }

        #endregion
    }
}
