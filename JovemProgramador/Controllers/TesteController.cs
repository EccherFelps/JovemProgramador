using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramador.Controllers
{
    public class TesteController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
