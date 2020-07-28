using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalFinance.WebApi.DAL;
using PersonalFinance.WebApi.Model;

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
        public ActionResult<IEnumerable<Competencia>> GetCompetencia()
        {
            var list = _context.List;
            return Ok(list);
        }

        // GET: api/Competencias/5
        [HttpGet("{id}")]
        public ActionResult<Competencia> GetCompetencia(int id)
        {
            var competencia = _context.Find(id);

            if (competencia == null)
            {
                return NotFound();
            }
            return competencia;
        }

        // PUT: api/Competencias
        [HttpPut]
        public IActionResult PutCompetencia(Competencia model)
        {
            if (ModelState.IsValid)
            {
                var competencia = _context.Find(model.Id);
                if (competencia != null)
                {
                    competencia = model;
                    _context.Update(competencia);

                    return Ok();
                }
            }
            return BadRequest();
        }

        // POST: api/Competencias
        [HttpPost]
        public ActionResult<Competencia> PostCompetencia(Competencia model)
        {
            if (ModelState.IsValid)
            {
                _context.Insert(model);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/Competencias/5
        [HttpDelete("{id}")]
        public ActionResult<Competencia> DeleteCompetencia(int id)
        {
            var competencia = _context.Find(id);
            if (competencia != null)
            {
                _context.Delete(competencia);
                return Ok();
            }
            return NotFound();
        }
        #endregion
    }
}
