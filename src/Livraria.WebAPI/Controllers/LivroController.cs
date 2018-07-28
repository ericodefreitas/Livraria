using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Livraria.ApplicationCore.Entity;
using Livraria.Infrastructure.Data;
using Livraria.ApplicationCore.Interfaces;

namespace Livraria.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/livro")]
    public class LivroController : Controller
    {
        private readonly ILivroService _service;

        public LivroController(ILivroService service)
        {
            _service = service;
        }

        #region GET

        // GET: api/Livro
        [HttpGet]
        public IEnumerable<Livro> GetLivros()
        {
            return _service.ObterTodos();
        }

        [HttpGet]
        [Route("OrdenarPorNome")]
        public IEnumerable<Livro> GetLivrosOrdenadosPorNome()
        {
            return _service.ObterTodosOrdenadosPorNome();
        }

        // GET: api/Livro/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLivro([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var livro = _service.ObterPorId(id);

            if (livro == null)
            {
                return NotFound();
            }

            return Ok(livro);
        }

        #endregion

        #region PUT

        // PUT: api/Livro/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLivro([FromRoute] int id, [FromBody] Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != livro.Id)
            {
                return BadRequest();
            }

            _service.Atualizar(livro);

            return CreatedAtAction("GetLivro", new { id = livro.Id }, livro);
        }

        #endregion

        #region POST

        // POST: api/Livro
        [HttpPost]
        public async Task<IActionResult> PostLivro([FromBody] Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _service.Adicionar(livro);

            return CreatedAtAction("GetLivro", new { id = livro.Id }, livro);
        }

        #endregion

        #region DELETE

        // DELETE: api/Livro/5
        [HttpDelete("{id}")]
        public void DeleteLivro([FromRoute] int id)
        {
            _service.Remover(id);
        }

        #endregion
    }
}