using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aec_gama_api.Models;

namespace aec_gama_api.Controllers
{
    [ApiController]
    public class ProfissoesController : ControllerBase
    {
        private readonly DbContexto _context;

        public ProfissoesController(DbContexto context)
        {
            _context = context;
        }

        // GET: Profissoes
        [HttpGet]
        [Route("/Profissoes")]
        public async Task<IActionResult> Index()
        {
            return StatusCode(200, await _context.Profissoes.ToListAsync());
        }

        // POST: Profissoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("/Profissoes")]
        public async Task<IActionResult> Create([Bind("Profissao, Id , Descricao")] Profissao profissao)
        {
            
            _context.Add(profissao);
            await _context.SaveChangesAsync();
            return StatusCode(201,profissao);
            
        }

        
        [HttpPut]
        [Route("/Profissoes/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Profissao, Id , Descricao")] Profissao profissao)
        {
            if (id != profissao.Id)
            {
                return NotFound();
            }

            try
            {
                _context.Update(profissao);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfissaoExists(profissao.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
                return StatusCode(200,profissao);
        }

        // POST: Profissoes/Delete/5
        [HttpDelete]
        [Route("/Profissoes/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var profissao = await _context.Profissoes.FindAsync(id);
            _context.Profissoes.Remove(profissao);
            await _context.SaveChangesAsync();
            return StatusCode(204);
        }

        [HttpGet]
        [Route("/Profissoes/{id}")]
        public async Task<Profissao> Get(int id)
        {
            var profissao = await _context.Profissoes.FindAsync(id);
            return profissao;
        }

        private bool ProfissaoExists(int id)
        {
            return _context.Profissoes.Any(e => e.Id == id);
        }
    }
}