using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zil.UI.Controllers
{
    public class InstructorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}