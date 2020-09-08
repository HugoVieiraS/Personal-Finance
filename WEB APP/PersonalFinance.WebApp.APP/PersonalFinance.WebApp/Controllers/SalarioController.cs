using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalFinance.WebApp.Model;
using PersonalFinance.WebApp.Repositories.Interfaces;

namespace PersonalFinance.WebApp.Controllers
{
    public class SalarioController : Controller
    {
        #region Propeties
        private readonly ISalarioRepository  _salarioRepository;
        #endregion

        #region Constructor
        public SalarioController(ISalarioRepository salarioRepository)
        {
            _salarioRepository = salarioRepository;
        }
        #endregion

        #region Methods
        public ActionResult Index()
        {
            var salario = _salarioRepository.List();
            return View(salario);
        }

        public ActionResult Details(int id)
        {
            var salario = _salarioRepository.Get(id);
            return View(salario);
        }

        public ActionResult Create()
        {
            var salario = new Salario();
            return View(salario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Salario model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _salarioRepository.Insert(model);
                    return RedirectToAction(nameof(Index));
                }
                catch (AggregateException ae) when (ae.InnerException != null && ae.InnerException is HttpRequestException)
                {
                    ViewBag.ErrorMessage = ae.InnerException.Message;
                }
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var salario = _salarioRepository.Get(id);
            return View(salario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Salario model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _salarioRepository.Edit(model);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var salario = _salarioRepository.Get(id);
            if (salario != null)
            {
                _salarioRepository.Delete(salario.Id);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        #endregion
    }
}
