using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        // GET api/calculator/divi/5/5
        [HttpGet("divi/{firstNumber}/{secondNumber}")]
        public IActionResult Divi (string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var divi = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);

                return Ok(divi.ToString());
            }

            return BadRequest("value");
        }

        // GET api/calculator/mult/5/5
        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult Mult(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);

                return Ok(mult.ToString());
            }

            return BadRequest("value");
        }

        // GET api/calculator/minus/5/5
        [HttpGet("minus/{firstNumber}/{secondNumber}")]
        public IActionResult Minus(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var minus = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);

                return Ok(minus.ToString());
            }

            return BadRequest("value");
        }

        // GET api/calculator/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("value");
        }

        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string StrNumber)
        {
            double number;

            bool isNumber = double.TryParse(StrNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);

            return isNumber;
        }
    }
}
