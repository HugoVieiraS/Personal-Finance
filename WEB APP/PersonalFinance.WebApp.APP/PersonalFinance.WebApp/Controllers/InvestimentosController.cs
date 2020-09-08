using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalFinance.WebApp.Model;
using PersonalFinance.WebApp.Repositories.Interfaces;
using PersonalFinance.WebApp.Repositories.Repository;

namespace PersonalFinance.WebApp.Controllers
{
    public class InvestimentosController : Controller
    {
        #region Propeties
        private readonly IInvestimentosRepository _investimentosRepository;
        #endregion

        #region Constructor
        public InvestimentosController(IInvestimentosRepository investimentosRepository)
        {
            _investimentosRepository = investimentosRepository;
        }
        #endregion

        #region Methods
        public ActionResult Index()
        {
            var investimentos = _investimentosRepository.List();
            return View(investimentos);
        }

        public ActionResult Details(int id)
        {
            var investimentos = _investimentosRepository.Get(id);
            return View(investimentos);
        }

        public ActionResult Create()
        {
            var investimentos = new Investimentos();
            return View(investimentos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Investimentos model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _investimentosRepository.Insert(model);
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
            var investimentos = _investimentosRepository.Get(id);
            return View(investimentos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Investimentos model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _investimentosRepository.Edit(model);
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
            var investimentos = _investimentosRepository.Get(id);
            if (investimentos != null)
            {
                _investimentosRepository.Delete(investimentos.Id);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        #endregion
    }
}
