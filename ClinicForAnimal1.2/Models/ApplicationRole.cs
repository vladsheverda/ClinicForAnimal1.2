using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicForAnimal1._2.Models
{
    public class ApplicationRole:IdentityRole
    {
        public ApplicationRole()
        {

        }
        public string Description { get; set; }
    }
}