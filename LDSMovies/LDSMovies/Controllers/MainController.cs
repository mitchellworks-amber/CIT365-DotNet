using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LDSMovies.Controllers
{
    public class MainController : Controller
    {
        // 
        // GET: /Main/

        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /Main/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}