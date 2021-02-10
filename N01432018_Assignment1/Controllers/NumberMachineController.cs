using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01432018_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Assignment Question 5
        /// Create a method which has an input {id}, and applies four mathematical operations to it.
        /// <param name="id"/></param>
        /// <returns></returns>
        /// GET api/NumberMachine/5 -> 20 (Using BEDMAS)
        
        /// It would return value after calculating 4 arithmetic operation.
        /// For example if,
        /// 1) id = 10 -> Answer = 98.
        /// 2) id = -5 -> Answer = 23
        /// 3) id = 30 -> Answer = 898.
        public int Get(int id)
        {
            return (id * id) - ( id + id) / id;
        }
    }
}
