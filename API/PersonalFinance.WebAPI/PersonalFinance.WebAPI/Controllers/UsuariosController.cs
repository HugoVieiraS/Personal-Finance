using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalFinance.WebApi.DAL;
using PersonalFinance.WebApi.Extensions;
using PersonalFinance.WebApi.Model;

namespace PersonalFinance.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        #region Fields
        private readonly IRepository<Usuarios> _context;
        #endregion

        #region Constructors
        public UsuariosController(IRepository<Usuarios> context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        //GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IList<Usuarios>>> GetContext()
        {
            var list = await _context.FindAllAsync();
            return Ok(list);
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public ActionResult<Usuarios> GetUsuarios(int id)
        {
            var usuarios = _context.Find(id);
            if (usuarios != null)
            {
                return Ok(usuarios.ToApi());
            }

            return NotFound();
        }

        // PUT: api/Usuarios
        [HttpPut]
        public async Task<IActionResult> PutUsuarios(Usuarios model)
        {
            if (ModelState.IsValid)
            {
                await _context.UpdateChangesAsync(model);
                return Ok();
            }

            return BadRequest();
        }

        // POST: api/Usuarios
        [HttpPost]
        public async Task<ActionResult<Usuarios>> PostUsuarios(Usuarios model)
        {
            if (ModelState.IsValid)
            {
                await _context.InsertAsync(model);
                return Ok();
            }

            return BadRequest();
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Usuarios>> DeleteUsuarios(int id)
        {
            var usuarios = await _context.FindAsync(id);
            if (usuarios != null)
            {
                await _context.RemoveAsync(usuarios);
                return Ok();
            }

            return BadRequest();
        }
        #endregion
    }
}
