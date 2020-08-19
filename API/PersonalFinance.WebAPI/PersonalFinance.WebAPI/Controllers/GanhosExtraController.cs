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
                return Ok(ganhoExtra.ToApi());
            }
            return NotFound();
        }

        // PUT: api/GanhosExtra
        [HttpPut]
        public ActionResult<GanhoExtra> PutGanhoExtra(GanhoExtraApi model)
        {
            if (ModelState.IsValid)
            {
                _context.Update(model.ToModel());
                return Ok();
            }
            return BadRequest();
        }

        // POST: api/GanhosExtra
        [HttpPost]
        public ActionResult<GanhoExtra> PostGanhoExtra(GanhoExtraApi model)
        {
            if (ModelState.IsValid)
            {
                _context.Insert(model.ToModel());
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
