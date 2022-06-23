using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace WebApplicationMVC.Controllers
{
    public class TestController : Controller
    {
        //Get: /Test/
        public IActionResult Index()
        {
            return View();
        }


        //GET: /Test/Welcome?name=Kyle&numtimes=4
        public IActionResult Welcome (string name, int numTimes =1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}
