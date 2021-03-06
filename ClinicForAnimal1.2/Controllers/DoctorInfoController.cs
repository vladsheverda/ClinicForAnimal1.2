﻿using ClinicForAnimal1._2.Models.DoctorInfo;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace ClinicForAnimal1._2.Controllers
{
    [Authorize(Roles = "admin")]
    public class DoctorInfoController : Controller
    {
        ClinicForAnimalEntities doctorInfo = new ClinicForAnimalEntities ();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DoctorInfoForAdmin doc)
        {
            doctorInfo.DoctorInfoForAdmins.Add(doc);
            doctorInfo.SaveChanges();
            return View();
        }



        [AllowAnonymous]
        public ActionResult ShowInfoDoctor()
        {
            List<DoctorInfoForAdmin> info = doctorInfo.DoctorInfoForAdmins.ToList();
            return View(info);
        }



        [HttpGet]
        public ActionResult Delete(int? id)
        {
            DoctorInfoForAdmin doc = doctorInfo.DoctorInfoForAdmins.Find(id);
            if (doc == null)
            {
                HttpNotFound();
            }
            return View(doc);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteDoctor(int? id)
        {
            DoctorInfoForAdmin doc = doctorInfo.DoctorInfoForAdmins.Find(id);
            if (doc == null)
            {
                HttpNotFound();
            }
            doctorInfo.Entry(doc).State = EntityState.Deleted;
            doctorInfo.SaveChanges();
            return View();
        }



        [HttpGet]
        public ActionResult EditDoctor(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            DoctorInfoForAdmin doc = doctorInfo.DoctorInfoForAdmins.Find(id);
            if (doc != null)
            {
                return View(doc);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult EditDoctor(DoctorInfoForAdmin doc)
        {
            doctorInfo.Entry(doc).State = EntityState.Modified;
            doctorInfo.SaveChanges();
            return View();
        }
    }
}