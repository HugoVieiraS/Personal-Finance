using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonalFinance.WebApi.DAL;
using PersonalFinance.WebApi.Extensions;
using PersonalFinance.WebApi.Model;
using PersonalFinance.WebApi.Model.Extensions;

namespace PersonalFinance.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
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
        public async Task<ActionResult<IList<Gastos>>> GetGastos()
        {
            var list = await _context.FindAllAsync();
            return Ok(list);
        }

        // GET: api/Gastos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gastos>> GetGastos(int id)
        {
            var gastos = await _context.FindAsync(id);
            if (gastos != null)
            {
                return Ok(gastos.ToApi());
            }

            return NotFound();
        }

        // PUT: api/Gastos
        [HttpPut]
        public async Task<IActionResult> PutGastos(GastosApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.UpdateChangesAsync(model.ToModel());
                return Ok();
            }
            return BadRequest();
        }

        // POST: api/Gastos
        [HttpPost]
        public async Task<ActionResult<Gastos>> PostGastos(GastosApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.InsertAsync(model.ToModel());
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/Gastos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Gastos>> DeleteGastos(int id)
        {
            var gastos = await _context.FindAsync(id);
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
