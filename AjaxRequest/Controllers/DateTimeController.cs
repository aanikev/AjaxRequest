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
    public class DateTimeController : Controller
    {
        // GET: DateTimeController
        [HttpGet]
        [Route("getDateTimeMethod")]
        public string getDateTimeMethod()
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
        

        
    }
}
