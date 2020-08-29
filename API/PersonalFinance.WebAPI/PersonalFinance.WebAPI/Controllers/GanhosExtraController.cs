using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalFinance.WebApi.DAL;
using PersonalFinance.WebApi.Model;
using PersonalFinance.WebApi.Model.Extensions;

namespace PersonalFinance.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class GanhosExtraController : ControllerBase
    {
        #region Fields
        private readonly IRepository<GanhoExtra> _context;
        #endregion

        #region Constructors
        public GanhosExtraController(IRepository<GanhoExtra> context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        // GET: api/GanhosExtra
        [HttpGet]
        public async Task<ActionResult<IList<GanhoExtra>>> GetGanhoExtra()
        {
            var list = await _context.FindAllAsync();
            return Ok(list);
        }

        // GET: api/GanhosExtra/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GanhoExtra>> GetGanhoExtra(int id)
        {
            var ganhoExtra = await _context.FindAsync(id);
            if (ganhoExtra != null)
            {
                return Ok(ganhoExtra.ToApi());
            }

            return NotFound();
        }

        // PUT: api/GanhosExtra
        [HttpPut]
        public async Task<IActionResult> PutGanhoExtra(GanhoExtraApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.UpdateChangesAsync(model.ToModel());
                return Ok();
            }
            return BadRequest();
        }

        // POST: api/GanhosExtra
        [HttpPost]
        public async Task<ActionResult<GanhoExtra>> PostGanhoExtra(GanhoExtraApi model)
        {
            if (ModelState.IsValid)
            {
                await _context.InsertAsync(model.ToModel());
                return Ok();
            }

            return BadRequest();
        }

        // DELETE: api/GanhosExtra/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GanhoExtra>> DeleteGanhoExtra(int id)
        {
            var ganhoExtra = _context.Find(id);
            if (ganhoExtra != null)
            {
                await _context.RemoveAsync(ganhoExtra);
                return Ok();
            }

            return NotFound();
        }
        #endregion
    }
}
