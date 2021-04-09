using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxRequest.Models
{
    public class MultiplicationModel
    {
        public MultiplicationModel(int result) 
        {
            Result = result;
            Success = true;
            Message = null;
        }
        public MultiplicationModel(string message)
        {
            Result = 0;
            Success = false;
            Message = message;
        }

        public int Result { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
