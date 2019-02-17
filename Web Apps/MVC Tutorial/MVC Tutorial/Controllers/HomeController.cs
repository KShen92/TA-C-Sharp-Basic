using MVC_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"D:\Tech Academy\TA-C-Sharp-Basic\Web Apps\MVC Tutorial\log.txt", text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return Content("Hello"); - plain text content

            //return RedirectToAction("Contact"); - redirect to other view

            //List<string> names = new List<String>
            //{
            //    "Jesse",
            //    "Ken",
            //    "Clayton"
            //};

            User user = new User();
            user.Id = 1;
            user.FirstName = "Ken";
            user.LastName = "Shen";
            user.Age = 26;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid page"); - creates error page

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}