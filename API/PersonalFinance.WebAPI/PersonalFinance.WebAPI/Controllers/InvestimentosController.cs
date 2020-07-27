﻿using System;
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
        public ActionResult<IEnumerable<Investimentos>> GetInvestimentos()
        {
            var list = _context.List;
            return Ok(list);
        }

        // GET: api/Investimentos/5
        [HttpGet("{id}")]
        public ActionResult<Investimentos> GetInvestimentos(int id)
        {
            var investimentos = _context.Find(id);
            if (investimentos != null)
            {
                return investimentos;
            }
            return NotFound();
        }

        //PUT: api/Investimentos
        [HttpPut]
        public IActionResult PutInvestimentos(Investimentos model)
        {
            if (ModelState.IsValid)
            {
                var investimentos = _context.Find(model.Id);
                if (investimentos != null)
                {
                    investimentos = model;
                    _context.Update(investimentos);

                    return Ok();
                }
            }
            return BadRequest();
        }

        // POST: api/Investimentos
        [HttpPost]
        public ActionResult<Investimentos> PostInvestimentos(Investimentos investimentos)
        {
            if (ModelState.IsValid)
            {
                _context.Insert(investimentos);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/Investimentos/5
        [HttpDelete("{id}")]
        public ActionResult<Investimentos> DeleteInvestimentos(int id)
        {
            var investimentos = _context.Find(id);
            if (investimentos != null)
            {
                _context.Delete(investimentos);
                return Ok();
            }
            return NotFound();
        }
        #endregion
    }
}