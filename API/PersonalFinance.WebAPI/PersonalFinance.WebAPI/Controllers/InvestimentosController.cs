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
    public class InvestimentosController : ControllerBase
    {
        #region Fields
        private readonly IRepository<Investimentos> _context;
        #endregion

        #region Constructors
        public InvestimentosController(IRepository<Investimentos> context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        // GET: api/Investimentos
        [HttpGet]
        public async Task<ActionResult<Investimentos>> GetInvestimentos()
        {
            var list = await _context.FindAllAsync();
            return Ok(list);
        }

        // GET: api/Investimentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Investimentos>> GetInvestimentos(int id)
        {
            var investimentos = await _context.FindAsync(id);
            if (investimentos != null)
            {
                return Ok(investimentos.ToApi());
            }
            return NotFound();
        }

        //PUT: api/Investimentos
        [HttpPut]
        public async Task<IActionResult> PutInvestimentos(InvestimentosApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.UpdateChangesAsync(model.ToModel());
                return Ok();
            }

            return BadRequest();
        }

        // POST: api/Investimentos
        [HttpPost]
        public async Task<ActionResult<Investimentos>> PostInvestimentos(InvestimentosApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.InsertAsync(model.ToModel());
                return Ok();
            }

            return BadRequest();
        }

        // DELETE: api/Investimentos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Investimentos>> DeleteInvestimentos(int id)
        {
            var investimentos = _context.Find(id);
            if (investimentos != null)
            {
                await _context.RemoveAsync(investimentos);
                return Ok();
            }

            return NotFound();
        }
        #endregion
    }
}
