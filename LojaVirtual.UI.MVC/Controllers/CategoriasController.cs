using LojaVirtual.Aplicacao.Interfaces;
using LojaVirtual.Aplicacao.ViewModels;
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriasViewModel categoria, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                appServiceCategorias.Register(categoria);
                return RedirectToAction("Index");

            }
            return View();
        }

        // GET: Categorias/Edit/5
        public ActionResult Edit(int id)
        {
            var categoria = appServiceCategorias.GetById(id);
            return View(categoria);
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategoriasViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                appServiceCategorias.Update(categoria);
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        // GET: Categorias/Delete/5
        public ActionResult Delete(int id)
        {
            var categoria = appServiceCategorias.GetById(id);
            return View(categoria);
        }

        // POST: Categorias/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CategoriasViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                appServiceCategorias.Remove(categoria);
                return RedirectToAction("Index");
            }
            return View(categoria);
        }
    }
}
