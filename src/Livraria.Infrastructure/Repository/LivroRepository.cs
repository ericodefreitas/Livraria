using Livraria.ApplicationCore.Entity;
using Livraria.ApplicationCore.Interfaces;
using Livraria.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livraria.Infrastructure.Repository
{
    public class LivroRepository: EFRepository<Livro>, ILivroRepository
    {
        public LivroRepository(LivroContext dbContext) : base (dbContext)
        {
        }

        #region Methods

        public IEnumerable<Livro> ObterTodosOrdenadosPorNome()
        {
            return _dbContext.Set<Livro>().OrderBy(x => x.Titulo);
        }

        #endregion
    }
}
