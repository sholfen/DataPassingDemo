using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataPassingDemo.Models;

namespace DataPassingDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult ViewDataTest()
        {
            ViewData["message"] = "this is a messsage from ViewData";
            return View();
        }

        public IActionResult ViewBagTest()
        {
            ViewBag.message = "this is a message from ViewBag";
            return View();
        }

        public IActionResult TempDataTest()
        {
            TempData["message"] = "this is a message from TempData";
            return Redirect("SecondPage");
        }

        public IActionResult SecondPage()
        {
            ViewData["message"] = TempData["message"];
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
