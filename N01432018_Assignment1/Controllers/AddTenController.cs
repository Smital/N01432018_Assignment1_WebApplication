using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01432018_Assignment1.Controllers
{
    public class AddTenController : ApiController

    {
        /// <summary>
        /// Assignment Question 1
        /// Returns 10 more than the integer input {id}........
        /// <param name="id"/></param>
        /// <returns></returns>
        /// GET api/AddTen/5 -> 10
        
        /// It would return addition of id value with 10
        /// For example if ,
        /// 1) id = 21 -> Answer = 31.
        /// 2) id = 0 -> Answer = 10
        /// 3) id = -9 -> Answer = 1.
        /// 
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
