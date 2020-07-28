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
        public ActionResult<IEnumerable<GanhoExtra>> GetGanhoExtra()
        {
            var list = _context.List;
            return Ok(list);
        }

        // GET: api/GanhosExtra/5
        [HttpGet("{id}")]
        public ActionResult<GanhoExtra> GetGanhoExtra(int id)
        {
            var ganhoExtra = _context.Find(id);
            if (ganhoExtra != null)
            {
                return ganhoExtra;
            }
            return NotFound();
        }

        // PUT: api/GanhosExtra
        [HttpPut]
        public IActionResult PutGanhoExtra(GanhoExtra model)
        {
            if (ModelState.IsValid)
            {
                var ganhoExtra = _context.Find(model.Id);
                if (ganhoExtra != null)
                {
                    ganhoExtra = model;
                    _context.Update(ganhoExtra);

                    return Ok();
                }
            }
            return BadRequest();
        }

        // POST: api/GanhosExtra
        [HttpPost]
        public ActionResult<GanhoExtra> PostGanhoExtra(GanhoExtra model)
        {
            if (ModelState.IsValid)
            {
                _context.Insert(model);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/GanhosExtra/5
        [HttpDelete("{id}")]
        public ActionResult<GanhoExtra> DeleteGanhoExtra(int id)
        {
            var ganhoExtra = _context.Find(id);
            if (ganhoExtra != null)
            {
                _context.Delete(ganhoExtra);
                return Ok();
            }
            return NotFound();
        }
        #endregion
    }
}
