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
                NumberA = 5,
                NumberB = 1,
                Operator = Operator.Add
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Calculator(CalcViewModel data)
        {
            // Do the operation
            var x = data.NumberA;
            var y = data.NumberB;
            var z = data.Operator;
          switch (z)
            {
                case Operator.Add:
                    data.Result = x + y;
                    break;
                case Operator.Substract:
                    data.Result = x - y;
                    break;
                case Operator.Multiply:
                    data.Result = x * y;
                    break;
                case Operator.Divide:
                    data.Result = x / y;
                    break;
            }
            return View("Calculator", data);
        }
    }
}