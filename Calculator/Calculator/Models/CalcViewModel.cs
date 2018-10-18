using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class CalcViewModel
    {
        [Display(Name = "Number A")]
        public int NumberA { get; set; }

        [Display(Name = "Number B")]
        public int NumberB { get; set; }

        public Operator Operator { get; set; }
    }

    public enum Operator
    {
        Divide = 0,
        Multiply = 1,
        Add = 2,
        Substract = 3
    }
}