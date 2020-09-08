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
    public class GanhoExtraController : Controller
    {
        #region Propeties
        private readonly IGanhoExtraRepository _ganhoExtraRepository;
        #endregion

        #region Constructor
        public GanhoExtraController(IGanhoExtraRepository ganhoExtraRepository)
        {
            _ganhoExtraRepository = ganhoExtraRepository;
        }
        #endregion

        #region Methods
        public ActionResult Index()
        {
            var ganhosExtras = _ganhoExtraRepository.List();
            return View(ganhosExtras);
        }

        public ActionResult Details(int id)
        {
            var ganhosExtra = _ganhoExtraRepository.Get(id);
            return View(ganhosExtra);
        }

        public ActionResult Create()
        {
            var ganhosExtra = new GanhoExtra();
            return View(ganhosExtra);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] GanhoExtra model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _ganhoExtraRepository.Insert(model);
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
            var ganhoExtra = _ganhoExtraRepository.Get(id);
            return View(ganhoExtra);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] GanhoExtra model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _ganhoExtraRepository.Edit(model);
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
            var ganhoExtra = _ganhoExtraRepository.Get(id);
            if (ganhoExtra != null)
            {
                _ganhoExtraRepository.Delete(ganhoExtra.Id);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        #endregion
    }
}
