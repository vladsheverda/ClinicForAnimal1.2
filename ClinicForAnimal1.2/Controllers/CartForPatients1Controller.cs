﻿using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ClinicForAnimal1._2.Models.PatientCart;

namespace ClinicForAnimal1._2.Controllers
{

    public class CartForPatients1Controller : Controller
    {
        private PatientCart db = new PatientCart();
        // GET: CartForPatients1
        public ActionResult Index()
        { 
            var a = db.CartForPatient.Include(c=>c.AspNetUser);
            return View(a.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            SelectList users = new SelectList(db.AspNetUsers, "Id", "UserName");
            ViewBag.AspNetUsers = users;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCaseRecord,Diagnosis,Treatment,IdPatient")] CartForPatient cartForPatient)
        {
            if (ModelState.IsValid)
            {
                db.CartForPatient.Add(cartForPatient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cartForPatient);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            CartForPatient cart = db.CartForPatient.Find(id);
            if (cart != null)
            {
                SelectList users = new SelectList(db.AspNetUsers, "Id", "UserName", cart.IdPatient);
                ViewBag.Users = users;
                return View(cart);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCaseRecord,Diagnosis,Treatment,IdPatient")] CartForPatient cartForPatient)
        {
            db.Entry(cartForPatient).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartForPatient cartForPatient = db.CartForPatient.Find(id);
            if (cartForPatient == null)
            {
                return HttpNotFound();
            }
            return View(cartForPatient);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CartForPatient cartForPatient = db.CartForPatient.Find(id);
            db.CartForPatient.Remove(cartForPatient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }





        [HttpPost]
        public ActionResult Search(string user)
        {
            var allinfo = db.AspNetUsers.Where(a => a.UserName.Contains(user)).ToList();
            if (allinfo.Count<=0)
            {
                HttpNotFound();
            }
            return PartialView(allinfo);
        }

        public ActionResult InfoAboutPatient()
        {
            return View();
        }
        #region
      

        #endregion
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
