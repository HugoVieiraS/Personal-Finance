using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalFinance.WebApp.Model;
using PersonalFinance.WebApp.Repositories.Interfaces;

namespace PersonalFinance.WebApp.Controllers
{
    public class ContaBancariaController : Controller
    {
        #region Propeties
        private readonly IContaBancariaRepository _contaBancariaRepository;
        #endregion

        #region Constructor
        public ContaBancariaController(IContaBancariaRepository contaBancariaRepository)
        {
            _contaBancariaRepository = contaBancariaRepository;
        }
        #endregion

        #region Methods
        public ActionResult Index()
        {
            var contasBancarias = _contaBancariaRepository.List();
            return View(contasBancarias);
        }

        public ActionResult Details(int id)
        {
            var conta = _contaBancariaRepository.Get(id);
            return View(conta);
        }

        public ActionResult Create()
        {
            var conta = new ContaBancaria();
            return View(conta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]ContaBancaria model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _contaBancariaRepository.Insert(model);
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
            var conta = _contaBancariaRepository.Get(id);
            return View(conta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] ContaBancaria model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contaBancariaRepository.Edit(model);
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
            var conta = _contaBancariaRepository.Get(id);
            if (conta != null)
            {
                _contaBancariaRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        #endregion
    }
}
