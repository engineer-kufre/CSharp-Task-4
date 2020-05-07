using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace MaxSquareCalc.Controllers {
    public class MaxSquareController : Controller {
        [HttpGet]
        public ActionResult MaxSquare () {
            return View ();
        }

        [HttpPost]
        public ActionResult MaxSquare (string firstnumber, string secondnumber) {
            try {
                double numberOne = double.Parse (firstnumber);
                double numberTwo = double.Parse (secondnumber);
                double numberOneSqrt = Math.Sqrt (numberOne);
                double numberTwoSqrt = Math.Sqrt (numberTwo);

                ViewBag.NumberOne = numberOne;
                ViewBag.NumberTwo = numberTwo;
                ViewBag.NumberOneSqrt = numberOneSqrt;
                ViewBag.NumberTwoSqrt = numberTwoSqrt;
            }
            catch (FormatException) {
                ViewBag.Error = "Format error! Please enter positive numbers only.";
            }
            return View ();
        }
    }
}