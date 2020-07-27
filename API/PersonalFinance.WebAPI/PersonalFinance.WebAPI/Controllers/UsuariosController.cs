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
        public ActionResult<IQueryable<Usuarios>> GetContext()
        {
            var list = _context.List.ToList();
            return Ok(list);
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public ActionResult<Usuarios> GetUsuarios(int id)
        {
            var usuarios = _context.Find(id);
            if (usuarios != null)
            {
                return Ok(usuarios);
            }

            return BadRequest();
        }

        // PUT: api/Usuarios
        [HttpPut]
        public IActionResult PutUsuarios(Usuarios model)
        {
            if (ModelState.IsValid)
            {
                var usuario = _context.Find(model.Id);
                if (usuario != null)
                {
                    usuario = model;
                    _context.Update(usuario);

                    return Ok();
                }
            }
            return BadRequest();
        }

        // POST: api/Usuarios
        [HttpPost]
        public ActionResult<Usuarios> PostUsuarios(Usuarios usuarios)
        {
            if (usuarios != null)
            {
                _context.Insert(usuarios);
                return Ok();
            }

            return BadRequest();
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public ActionResult<Usuarios> DeleteUsuarios(int id)
        {
            var usuarios = _context.Find(id);
            if (usuarios == null)
            {
                return NotFound();
            }
            _context.Delete(usuarios);

            return Ok();
        }
        #endregion
    }
}
