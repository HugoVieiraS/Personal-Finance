using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonalFinance.WebApi.DAL;
using PersonalFinance.WebApi.Model;
using PersonalFinance.WebApi.Model.Extensions;

namespace PersonalFinance.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class SalarioController : ControllerBase
    {
        #region Fields
        private readonly IRepository<Salario> _context;
        #endregion

        #region Constructors
        public SalarioController(IRepository<Salario> context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        // GET: api/GanhoFixo
        [HttpGet]
        public async Task<ActionResult<IList<Salario>>> GetList()
        {
            var list = await _context.FindAllAsync();
            return Ok(list);
        }

        // GET: api/Salario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalarioApi>> GetSalario(int id)
        {
            var salario = await _context.FindAsync(id);
            if (salario != null)
            {
                return Ok(salario.ToApi());
            }

            return NotFound();
        }

        // PUT: api/Salario
        [HttpPut]
        public async Task<IActionResult> PutSalario(SalarioApi ganhoFixo)
        {
            if (ModelState.IsValid)
            {
                await _context.UpdateChangesAsync(ganhoFixo.ToModel());
                return Ok();
            }

            return NotFound();
        }

        // POST: api/Salario
        [HttpPost]
        public async Task<ActionResult<Salario>> PostSalario(SalarioApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.InsertAsync(model.ToModel());
                return Ok();
            }

            return BadRequest();
        }

        // DELETE: api/Salario/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Salario>> DeleteSalario(int id)
        {
            var salario = await _context.FindAsync(id);
            if (salario != null)
            {
                _context.Delete(salario);
                return Ok();
            }

            return NotFound();
        }
        #endregion
    }
}
