using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class BootcampController : Controller {

        public IActionResult Index(){
            return View();
        }
        public IActionResult List(){
            return View();
        }
    }
}