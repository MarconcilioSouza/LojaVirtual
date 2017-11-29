using LojaVirtual.Aplicacao.Interfaces;
using LojaVirtual.Aplicacao.ViewModels;
using System;
using System.Web.Mvc;

namespace LojaVirtual.UI.MVC.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly IAppServiceCategorias appServiceCategorias;
        public CategoriasController(IAppServiceCategorias _appServiceCategorias)
        {
            appServiceCategorias = _appServiceCategorias;
        }

        // GET: Categorias
        public ActionResult Index()
        {
            var categorias = appServiceCategorias.GetAll();
            return View(categorias);
        }

        // GET: Categorias/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        [HttpPost]
        public ActionResult Create(CategoriasViewModel categoria,FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appServiceCategorias.Register(categoria);
                }

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Categorias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categorias/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
