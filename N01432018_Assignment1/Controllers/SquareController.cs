using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01432018_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Assignment Question 2
        /// Returns the square of the integer input {id}..
        /// <param name="id"/></param>
        /// <returns></returns>
        /// GET api/AddTen/5 -> 25
       
        /// It would return square of id value
        /// For example if ,
        /// 1) id = 2 -> Answer = 2.
        /// 2) id = -2 -> Answer = 4
        /// 3) id = 10 -> Answer = 100.
        public int Get(int id)
        {
            return id * id;
        }
    }
}
