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
    public class GastosController : Controller
    {
        #region Propeties
        private readonly IGastosRepository _gastosRepository;
        #endregion

        #region Constructor
        public GastosController(IGastosRepository gastosRepository)
        {
            _gastosRepository = gastosRepository;
        }
        #endregion

        #region Methods
        public ActionResult Index()
        {
            var gastos = _gastosRepository.List();
            return View(gastos);
        }

        public ActionResult Details(int id)
        {
            var gastos = _gastosRepository.Get(id);
            return View(gastos);
        }

        public ActionResult Create()
        {
            var gastos = new Gastos();
            return View(gastos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Gastos model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _gastosRepository.Insert(model);
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
            var gastos = _gastosRepository.Get(id);
            return View(gastos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Gastos model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _gastosRepository.Edit(model);
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
            var gastos = _gastosRepository.Get(id);
            if (gastos != null)
            {
                _gastosRepository.Delete(gastos.Id);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        #endregion
    }
}
