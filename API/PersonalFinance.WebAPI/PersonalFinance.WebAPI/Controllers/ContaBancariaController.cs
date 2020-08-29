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
    public class ContaBancariaController : ControllerBase
    {
        #region Fields
        private readonly IRepository<ContaBancaria> _context;
        #endregion

        #region Constructor
        public ContaBancariaController(IRepository<ContaBancaria> context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        // GET: api/ContaBancaria
        [HttpGet]
        public async Task<ActionResult<IList<ContaBancaria>>> GetContaBancaria()
        {
            IList<ContaBancaria> list = await _context.FindAllAsync();
            return Ok(list);
        }

        // GET: api/ContaBancaria/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContaBancaria>> GetContaBancaria(int id)
        {
            var contaBancaria = await _context.FindAsync(id);
            if (contaBancaria != null)
            {
                return Ok(contaBancaria.ToApi());
            }

            return NotFound();
        }

        // POST: api/ContaBancaria
        [HttpPost]
        public async Task<ActionResult<ContaBancaria>> PostContaBancaria(ContaBancariaApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.InsertAsync(model.ToModel());
                return Ok();
            }

            return BadRequest();
        }

        // PUT: api/ContaBancaria
        [HttpPut]
        public async Task<IActionResult> PutContaBancaria(ContaBancariaApi model)
        {
            if (ModelState.IsValid)
            {
                var conta = model.ToModel();
                await _context.UpdateChangesAsync(conta);
                return Ok();
            }

            return BadRequest();
        }

        // DELETE: api/ContaBancaria/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ContaBancaria>> DeleteContaBancaria(int id)
        {
            var contaBancaria = await _context.FindAsync(id);
            if (contaBancaria != null)
            {
                await _context.RemoveAsync(contaBancaria);
                return Ok();
            }

            return NotFound();
        }
        #endregion
    }
}
