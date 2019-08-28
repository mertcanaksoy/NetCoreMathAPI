using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreMathAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreMathAPI.Controllers
{
    [Route("api/[controller]")]
    public class OperationController : Controller
    {
        [Route("/operation/addition/{parameter1}/{parameter2}")]
        [HttpGet]
        [HttpPost]
        public int AdditionResult(int parameter1, int parameter2)
        {
            int result = Operation.Addition(parameter1, parameter2);
            Console.WriteLine("Addition Succeed "+result);
            return result;
        }

        [Route("/operation/subtraction/{parameter1}/{parameter2}")]
        [HttpGet]
        [HttpPost]
        public int SubtractionResult(int parameter1, int parameter2)
        {
            int result = Operation.Subtraction(parameter1, parameter2);
            Console.WriteLine("Subtraction Succeed " + result);
            return result;
        }

        [Route("/operation/pow/{parameter1}/{parameter2}")]
        [HttpGet]
        [HttpPost]
        public double PowResult(int parameter1, int parameter2)
        {
            double result = Operation.Pow(parameter1, parameter2);
            Console.WriteLine("Pow Succeed " + result);
            return result;
        }

        

    }
}
