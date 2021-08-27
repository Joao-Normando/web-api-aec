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
    public class CandidatosController : ControllerBase
    {
        private readonly DbContexto _context;

        public CandidatosController(DbContexto context)
        {
            _context = context;
        }

        // GET: Candidatos
        [HttpGet]
        [Route("/Candidatos")]
        public async Task<IActionResult> Index()
        {
            return StatusCode(200, await _context.Candidatos.ToListAsync());
        }

        // POST: Candidatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("/Candidatos")]
        public async Task<IActionResult> Create(
            [Bind("Id_Candidato,Nome,Nascimento,Cep,Endereco,"+
           "Numero,Bairro,Cidade,UF,Telefone,Email,"+
           "ProfissaoID")] Candidato candidato)
        {
            
            _context.Add(candidato);
            await _context.SaveChangesAsync();
            return StatusCode(201,candidato);
            
        }

        
        [HttpPut]
        [Route("/Candidatos/{id}")]
        public async Task<IActionResult> Edit(
            int id, [Bind("Id_Candidato,Nome,Nascimento,Cep,Endereco,"+
           "Numero,Bairro,Cidade,UF,Telefone,Email,"+
           "ProfissaoID")] Candidato candidato)
        {
            if (id != candidato.Id_Candidato)
            {
                return NotFound();
            }

            try
            {
                _context.Update(candidato);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidatoExists(candidato.Id_Candidato))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
                return StatusCode(200,candidato);
        }

        // POST: Candidatos/Delete/5
        [HttpDelete]
        [Route("/Candidatos/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var candidato = await _context.Candidatos.FindAsync(id);
            _context.Candidatos.Remove(candidato);
            await _context.SaveChangesAsync();
            return StatusCode(204);
        }

        [HttpGet]
        [Route("/Candidatos/{id}")]
        public async Task<Candidato> Get(int id)
        {
            var candidato = await _context.Candidatos.FindAsync(id);
            return candidato;
        }

        private bool CandidatoExists(int id)
        {
            return _context.Candidatos.Any( e => e.Id_Candidato == id);
        }
    }
}