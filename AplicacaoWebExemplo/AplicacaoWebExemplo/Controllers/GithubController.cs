using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacaoWebExemplo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWebExemplo.Controllers
{   
    //[Route("apirest")]
    public class GithubController : Controller
    {
        // GET: Github
        public ActionResult Index()
        {
            return View();
        }

        // GET: Github/Repositorios/5
        [HttpGet("repositorios/{ident?}")]
        public ActionResult Repositorios(string ident)
        {
            Repositorio rep = new Repositorio { Id = ident };
            ViewBag.Repositorio = rep;
            
            return View();
        }

        // GET: Github/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Github/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Github/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Github/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Github/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Github/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}