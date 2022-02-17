using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Controllers
{
    public class hhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
