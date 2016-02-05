using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicForAnimal1._2.Controllers
{
    public class SecretController : Controller
    {
        // GET: Secret
        [Authorize]
        public string Secret()
        {
            return "I'm a secret action. Only registred users should see me!!";
        }
        [AllowAnonymous]
        public string Public()
        {
            return "I'm a public action. Everybody can see me";
        }
    }
}