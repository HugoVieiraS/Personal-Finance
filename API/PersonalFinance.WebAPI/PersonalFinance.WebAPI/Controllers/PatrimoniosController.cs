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
    public class PatrimoniosController : ControllerBase
    {
        #region Fields
        private readonly IRepository<Patrimonio> _context;
        #endregion

        #region Constructors
        public PatrimoniosController(IRepository<Patrimonio> context)
        {
            _context = context;
        }
        #endregion

        // GET: api/Patrimonios
        [HttpGet]
        public ActionResult<IEnumerable<Patrimonio>> GetPatrimonio()
        {
            var list = _context.List;
            return Ok(list);
        }

        // GET: api/Patrimonios/5
        [HttpGet("{id}")]
        public ActionResult<Patrimonio> GetPatrimonio(int id)
        {
            var patrimonio = _context.Find(id);
            if (patrimonio == null)
            {
                return NotFound();
            }

            return patrimonio;
        }

        // PUT: api/Patrimonios/5
        [HttpPut]
        public IActionResult PutPatrimonio(Patrimonio model)
        {
            if (ModelState.IsValid)
            {
                var patrimonio = _context.Find(model.Id);
                if (patrimonio != null)
                {
                    patrimonio = model;
                    _context.Update(patrimonio);

                    return Ok();
                }
            }
            return BadRequest();
        }

        // POST: api/Patrimonios
        [HttpPost]
        public async Task<ActionResult<Patrimonio>> PostPatrimonio(Patrimonio model)
        {
            if (ModelState.IsValid)
            {
                _context.Insert(model);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/Patrimonios/5
        [HttpDelete("{id}")]
        public ActionResult<Patrimonio> DeletePatrimonio(int id)
        {
            var patrimonio = _context.Find(id);
            if (patrimonio != null)
            {
                _context.Delete(patrimonio);
                return Ok();
            }
            return NotFound();
        }
    }
}
