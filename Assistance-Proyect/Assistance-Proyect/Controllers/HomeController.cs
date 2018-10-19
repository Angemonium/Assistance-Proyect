using Assistance_Proyect.ViewModels;
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
                    data.Result = (x + y);
                    break;
                case Operator.Substract:
                    data.Result = (x - y);
                    break;
                case Operator.Multiply:
                    data.Result = (x * y);
                    break;
                case Operator.Divide:
                    try { 
                        data.Result = x / y;
                        break;
                        }
                    catch(DivideByZeroException)
                    {
                        data.Result = 0;
                        break;
                    }
            }
            return View("Calculator", data);
        }
    }
}
