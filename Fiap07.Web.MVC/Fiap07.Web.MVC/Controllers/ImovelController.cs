﻿using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class ImovelController : Controller
    {
        private ImobiliariaContext _context = new ImobiliariaContext();

        [HttpGet]
        public ActionResult Listar()
        {
            //Include -> carrega os dados do relacionamento
            var lista = _context.Imoveis.Include("Categoria").ToList();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar por todas as categorias
            var lista = _context.Categorias.ToList();
            //Enviar para a tela a lista de categorias para o select
            ViewBag.categorias = new SelectList(lista, "CategoriaId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Imovel imovel)
        {
            _context.Imoveis.Add(imovel);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}