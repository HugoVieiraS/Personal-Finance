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
    public class CompetenciaController : Controller
    {
        #region Propeties
        private readonly ICompetenciaRepository _competenciaRepository;
        #endregion

        #region Constructor
        public CompetenciaController(ICompetenciaRepository competenciaRepository)
        {
            _competenciaRepository = competenciaRepository;
        }
        #endregion

        #region Methods
        // GET: HomeController
        public ActionResult Index()
        {
            var competencias = _competenciaRepository.List();
            return View(competencias);
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            var competencia = _competenciaRepository.Get(id);
            return View(competencia);
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            var competencia = new Competencia();
            return View(competencia);
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Competencia model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _competenciaRepository.Insert(model);
                    return RedirectToAction(nameof(Index));
                }
                catch (AggregateException ae) when (ae.InnerException != null && ae.InnerException is HttpRequestException)
                {

                    ViewBag.ErrorMessage = ae.InnerException.Message;
                }
            }

            return View(model);
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            var competencia = _competenciaRepository.Get(id);
            return View(competencia);
        }

        // POST: HomeController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Competencia model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _competenciaRepository.Edit(model);
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
            var competencia = _competenciaRepository.Get(id);
            if (competencia != null)
            {
                _competenciaRepository.Delete(competencia.Id);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
        #endregion
    }
}
