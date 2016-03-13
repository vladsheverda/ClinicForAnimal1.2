using ClinicForAnimal1._2.Models.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ClinicForAnimal1._2.Controllers.ExtraController
{
    public class NavController : Controller
    {
        private VerServices db = new VerServices();
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = db.VeterinarianServices
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}
