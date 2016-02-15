using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ClinicForAnimal1._2.Models.Services.Category;

namespace ClinicForAnimal1._2.Controllers
{
    [Authorize(Roles ="admin")]
    public class CategoryServicesController : Controller
    {
        private CategoryForServices db = new CategoryForServices();

        // GET: CategoryServices
        public ActionResult Index()
        {
            return View(db.CategoryServices.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryService categoryService = db.CategoryServices.Find(id);
            if (categoryService == null)
            {
                return HttpNotFound();
            }
            return View(categoryService);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CategoryName")] CategoryService categoryService)
        {
            if (ModelState.IsValid)
            {
                db.CategoryServices.Add(categoryService);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryService);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryService categoryService = db.CategoryServices.Find(id);
            if (categoryService == null)
            {
                return HttpNotFound();
            }
            return View(categoryService);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CategoryName")] CategoryService categoryService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoryService).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryService);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryService categoryService = db.CategoryServices.Find(id);
            if (categoryService == null)
            {
                return HttpNotFound();
            }
            return View(categoryService);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoryService categoryService = db.CategoryServices.Find(id);
            db.CategoryServices.Remove(categoryService);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

 
    }
}
