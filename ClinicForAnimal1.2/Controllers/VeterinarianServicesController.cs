using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClinicForAnimal1._2.Models.Services;

namespace ClinicForAnimal1._2.Controllers
{
    [Authorize(Roles = "admin")]
    public class VeterinarianServicesController : Controller
    {
        private VerServices db = new VerServices();

        // GET: VeterinarianServices
        public ActionResult Index()
        {
            return View(db.VeterinarianServices.ToList());
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VeterinarianService veterinarianService = db.VeterinarianServices.Find(id);
            if (veterinarianService == null)
            {
                return HttpNotFound();
            }
            return View(veterinarianService);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NameOfVeterinaryServices,UnitOfMeasurement,Cost,Category")] VeterinarianService veterinarianService)
        {
            if (ModelState.IsValid)
            {
                db.VeterinarianServices.Add(veterinarianService);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veterinarianService);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VeterinarianService veterinarianService = db.VeterinarianServices.Find(id);
            if (veterinarianService == null)
            {
                return HttpNotFound();
            }
            return View(veterinarianService);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NameOfVeterinaryServices,UnitOfMeasurement,Cost,Category")] VeterinarianService veterinarianService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veterinarianService).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veterinarianService);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VeterinarianService veterinarianService = db.VeterinarianServices.Find(id);
            if (veterinarianService == null)
            {
                return HttpNotFound();
            }
            return View(veterinarianService);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VeterinarianService veterinarianService = db.VeterinarianServices.Find(id);
            db.VeterinarianServices.Remove(veterinarianService);
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
        [AllowAnonymous]
        public ActionResult ShowCategory()
        {
            List<VeterinarianService> info = db.VeterinarianServices.ToList();
            return View(info);
        }
    }
}
