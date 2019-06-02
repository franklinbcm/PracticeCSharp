using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static MVCPractice.Models.HomeModel;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.Employees emp)
        {
            if (string.IsNullOrEmpty(emp.Employee))
                ModelState.AddModelError("Employee", new Exception());
            if (ModelState.IsValid)
            {

                return RedirectToAction("Message");
            }
            return View();
        }
        [HttpGet]
        public JsonResult LoadFile(string fileLocation, string fileName)
        {
            try
            {
                fileLocation =   @"c:\users\user\source\repos\PracticeCSharp\MVCPractice\Files\testRead.txt";
                string[] lines = System.IO.File.ReadAllLines(fileLocation);
 
                // Display the file contents by using a foreach loop.
                foreach (string line in lines)
                {
                   
                    
                    DocumentF101 model = new DocumentF101();
                    var spl = line.Split('\t');
                    model.DocumentID = spl[0];
                    model.Name = spl[1];
 
                    if (TryValidateModel(model))
                    {
                        Console.WriteLine("\t" + line);

                    }

                    // Use a tab to indent each line of the file.
                    Console.WriteLine("\t" + "Fallo");
                }
            }
            catch (Exception ex)
            {

                
            }

            return Json(new object());
        }

        public ActionResult Message()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}