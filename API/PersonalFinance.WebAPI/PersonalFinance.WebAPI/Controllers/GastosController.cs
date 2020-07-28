using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PersonalFinance.WebApi.DAL;
using PersonalFinance.WebApi.Model;

namespace PersonalFinance.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastosController : ControllerBase
    {
        #region Fields
        private readonly IRepository<Gastos> _context;
        #endregion

        #region Constructors
        public GastosController(IRepository<Gastos> context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        // GET: api/Gastos
        [HttpGet]
        public ActionResult<IEnumerable<Gastos>> GetGastos()
        {
            var list = _context.List;
            return Ok(list);
        }

        // GET: api/Gastos/5
        [HttpGet("{id}")]
        public ActionResult<Gastos> GetGastos(int id)
        {
            var gastos = _context.Find(id);

            if (gastos == null)
            {
                return NotFound();
            }

            return gastos;
        }

        // PUT: api/Gastos
        [HttpPut]
        public IActionResult PutGastos(Gastos model)
        {
            if (ModelState.IsValid)
            {
                var gastos = _context.Find(model.Id);
                if (gastos != null)
                {
                    gastos = model;
                    _context.Update(gastos);

                    return Ok();
                }
            }
            return BadRequest();
        }

        // POST: api/Gastos
        [HttpPost]
        public ActionResult<Gastos> PostGastos(Gastos gastos)
        {
            if (ModelState.IsValid)
            {
                _context.Insert(gastos);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/Gastos/5
        [HttpDelete("{id}")]
        public ActionResult<Gastos> DeleteGastos(int id)
        {
            var gastos = _context.Find(id);
            if (gastos != null)
            {
                _context.Delete(gastos);
                return Ok();
            }
            return NotFound();
        }
        #endregion
    }
}
