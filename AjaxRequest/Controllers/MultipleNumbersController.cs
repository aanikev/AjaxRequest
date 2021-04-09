using AjaxRequest.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxRequest.Controllers
{
    [ApiController]
    //[Route("MultipleNumbers")]
    //[EnableCors("MyPolicy")]
    public class MultipleNumbersController : Controller
    {
        [HttpGet]
        [Route("sdfsdf")]
        public string getDateTimeMethod()
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        

        // POST: MultipleNumbers/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("MultipleNumbers")]
        public MultiplicationModel MultipleNumbers([FromBody] Numbers numbers)
        {
            try
            {
                if (numbers.X > 1000 || numbers.Y > 1000)
                {
                    throw new Exception("Слишком большое число");
                }
               int result = numbers.X * numbers.Y;
               return new MultiplicationModel(result);
            }
            catch (Exception error)
            {
                return new MultiplicationModel(error.Message);
            }
            
        }

        [HttpGet]
        //[ValidateAntiForgeryToken]
        [Route("MultipleNumbersGet")]
        public int MultipleNumbersGet(int x, int y)
        {
            return 123;
        }

    }
}
