using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assistance_Proyect.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public class CalcViewModel
        {
            [Display(Name = "Number A")]
            public int NumberA { get; set; }

            [Display(Name = "Number B")]
            public int NumberB { get; set; }

            public Operator Operator { get; set; }

            public int? Result { get; set; }
        }

        public enum Operator
        {
            Divide = 0,
            Multiply = 1,
            Add = 2,
            Substract = 3
        }

        [HttpGet]
        public ActionResult Calculator()
        {
            CalcViewModel model = new CalcViewModel()
            {
                NumberA = 1,
                NumberB = 1,
                Operator = Operator.Add
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Calculator(CalcViewModel data)
        {
            // Do the operation
            var x = data;


            data.Result = 10;

            return View("Calculator", data);
        }
    }
}