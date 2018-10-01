using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap08.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var times = _unit.TimeRepository.Listar();
            ViewBag.times = new SelectList(times, "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _unit.JogadorRepository.Cadastrar(jogador);
            _unit.Salvar();
            TempData["msg"] = "Jogador cadastrado";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}