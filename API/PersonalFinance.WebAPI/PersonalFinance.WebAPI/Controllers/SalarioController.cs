using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalFinance.WebApi.DAL;
using PersonalFinance.WebApi.Model;
using PersonalFinance.WebApi.Model.Extensions;

namespace PersonalFinance.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
