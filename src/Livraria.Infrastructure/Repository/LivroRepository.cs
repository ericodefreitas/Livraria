using Livraria.ApplicationCore.Entity;
using Livraria.ApplicationCore.Interfaces;
using Livraria.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Infrastructure.Repository
{
    public class LivroRepository: EFRepository<Livro>, ILivroRepository
    {
        public LivroRepository(LivroContext dbContext) : base (dbContext)
        {
        }
    }
}
