using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalFinance.WebApi.DAL;
using PersonalFinance.WebApi.Model;
using PersonalFinance.WebApi.Extensions;

namespace PersonalFinance.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetenciasController : ControllerBase
    {
        #region Fields
        private readonly IRepository<Competencia> _context;
        #endregion

        #region Constructors
        public CompetenciasController(IRepository<Competencia> context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        // GET: api/Competencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competencia>>> GetCompetencia()
        {
            IList<Competencia> list = await _context.FindAllAsync();
            return Ok(list);
        }

        // GET: api/Competencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompetenciaApi>> GetCompetencia(int id)
        {
            var competencia = await _context.FindAsync(id);
            if (competencia != null)
            {
                return Ok(competencia.ToApi());
            }

            return NotFound();
        }

        // PUT: api/Competencias
        [HttpPut]
        public async Task<IActionResult> PutCompetencia(CompetenciaApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.UpdateChangesAsync(model.ToModel());
                return Ok();
            }

            return BadRequest();
        }

        // POST: api/Competencias
        [HttpPost]
        public async Task<ActionResult<Competencia>> PostCompetencia(CompetenciaApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.InsertAsync(model.ToModel());
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/Competencias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Competencia>> DeleteCompetencia(int id)
        {
            var competencia = _context.Find(id);
            if (competencia != null)
            {
                await _context.RemoveAsync(competencia);
                return Ok();
            }

            return NotFound();
        }
        #endregion

        #region Private Method
        private void AbrirCompetencia(CompetenciaApi model)
        {
           _context.Insert(model.ToModel());
        }

        private void FecharCompetencia(CompetenciaApi model)
        {
            var competencia = _context.Find(model.Id);
            competencia.DataFinal = Convert.ToDateTime(model.DataFinal);
            
            _context.Update(competencia);
        }
        #endregion
    }
}
