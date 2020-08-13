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
        public ActionResult<IEnumerable<Salario>> GetList()
        {
            var list = _context.List;
            return Ok(list);
        }

        // GET: api/Salario/5
        [HttpGet("{id}")]
        public ActionResult<SalarioApi> GetSalario(int id)
        {
            var salario = _context.Find(id);
            if (salario != null)
            {
                return Ok(salario.ToApi());
            }
            return NotFound();
        }

        // PUT: api/Salario
        [HttpPut]
        public ActionResult<Salario> PutSalario(int id, Salario ganhoFixo)
        {
            if (id != ganhoFixo.Id)
            {
                return NotFound();
            }
            _context.Update(ganhoFixo);

            return Ok();
        }

        // POST: api/Salario
        [HttpPost("{id}")]
        public ActionResult<Salario> PostSalario(SalarioApi model)
        {
            if (ModelState.IsValid)
            {
                _context.Insert(model.ToModel());
                return Ok();
            }

            return BadRequest();
        }

        // DELETE: api/Salario/5
        [HttpDelete("{id}")]
        public ActionResult<Salario> DeleteSalario(int id)
        {
            var salario = _context.Find(id);
            if (salario == null)
            {
                return NotFound();
            }
            _context.Delete(salario);

            return Ok();
        }
        #endregion
    }
}
