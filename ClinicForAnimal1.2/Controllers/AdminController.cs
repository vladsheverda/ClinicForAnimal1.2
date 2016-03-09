using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicForAnimal1._2.Controllers
{
    //[Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult InfoForAdmin()
        {
            return View();
        }
    }
}