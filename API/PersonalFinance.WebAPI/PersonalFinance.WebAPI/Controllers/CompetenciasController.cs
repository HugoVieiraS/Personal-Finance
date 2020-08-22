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
        private readonly IRepository<GanhoExtra> _ganhoExtra;
        private readonly IRepository<Gastos> _gastos;
        private readonly IRepository<Salario> _salario;
        #endregion

        #region Constructors
        public CompetenciasController(IRepository<Competencia> context, IRepository<GanhoExtra> ganhoExtra,
                                      IRepository<Salario> salario, IRepository<Gastos> gastos)
        {
            _context = context;
            _ganhoExtra = ganhoExtra;
            _salario = salario;
            _gastos = gastos;
        }
        #endregion

        #region Methods
        //GET: api/Competencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompetenciaApi>>> GetCompetencia()
        {
            var list = await _context.FindAllAsync();
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

        // POST: api/Competencias
        [HttpPost]
        public async Task<ActionResult<Competencia>> AbrirCompetencia(CompetenciaApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.InsertAsync(model.ToModel());
                return Ok();
            }
            return BadRequest();
        }
        
        // PUT: api/Competencias
        [HttpPut]
        public async Task<ActionResult<Competencia>> FecharCompetencia(CompetenciaApi model)
        {
            if (ModelState.IsValid)
            {
                await FechamentoOrcamento(model);
                await _context.UpdateChangesAsync(model.ToModel());
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

        #region Private Methods
        private async Task FechamentoOrcamento(CompetenciaApi model)
        {
            var salario = await _salario.FindAllAsync();
            var ganhos =  await _ganhoExtra.FindAllAsync();
            var gastos =  await _gastos.FindAllAsync();

            model.ValorGasto = model.ValorGasto = gastos.Where(x => x.CompetenciaId == model.Id).ToList().Sum(x => x.Valor);

            model.ValorGanho = salario.Where(x => x.CompetenciaId == model.Id).Select(x => x.ValorLiquido).Sum() 
                + ganhos.Where(x => x.CompetenciaId == model.Id).Sum(x => x.Valor);
         
            model.ValorSobra = model.ValorGanho - model.ValorGasto;
        }      
        #endregion

    }
}
