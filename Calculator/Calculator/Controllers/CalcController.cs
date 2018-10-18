using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult index(int res)
        {
            int val1 = int.Parse(Request.Form["val1"].ToString());
            int val2 = int.Parse(Request.Form["val2"].ToString());
            string oper = Request.Form["oper"].ToString();
            Calculadora calc = new Calculadora();
            switch (oper)
            {
                case "+":
                    try {
                        calc.suma(val1, val2);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No es un formato soportado");
                    }
                    break;

                case "-":
                    try
                    {
                        calc.resta(val1, val2);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No es un formato soportado");
                    }
                    break;
                   

                case "*":
                    try
                    {
                        calc.mult(val1, val2);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No es un formato soportado");
                    }
                    break;
                    

                case "/":
                    try
                    {
                        calc.d(val1, val2);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("No es un formato soportado");
                    }
                    break;
                default:
                    Console.WriteLine("No es un operador valido");
                    break;
            }
            return View(res);
        }
    }
    }
