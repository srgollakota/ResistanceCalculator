using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OhmCalculator.Models;
using ResistanceCalculator.Web.Models;

namespace OhmCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new ColorModel();
            return View(model);
        }

       
    }
}
