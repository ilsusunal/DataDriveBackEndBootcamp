using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class BootcampController : Controller
    {
        public string Index(){
            return "Bootcamp Page";
        }
    }
}