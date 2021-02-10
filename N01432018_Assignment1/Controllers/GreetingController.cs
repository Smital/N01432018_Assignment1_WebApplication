using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01432018_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Assignment Question 3
        /// Returns the string “Hello World!”
        /// <param name="id"/></param>
        /// <returns></returns>
        /// POST api/Greeting/5
        /// </summary>
        
        /// It would return string with "Hello World" with POST request.
        /// Output Can be seen using Command Prompt
        /// Input:curl -d "" "http://localhost:64221/api/Greeting/5"
        /// Output:HELLO WORLD

        public string POST(int id)
        {
        
            return "HELLO WORLD";
        }

        /// <summary>
        /// Assignment Question 4
        /// Returns the string “Greetings to {id} people!” where id is an integer value.
        /// <param name="id"/></param>
        /// <returns></returns>
        /// GET api/Greeting/5 -> Greetings to 5 people!
        /// </summary>

        /// It would return the statment with given id value
        /// For example if 
        /// 1) id = 3 -> Answer = Greetings to 3 people.
        /// 2) id = 6 -> Answer = Greetings to 6 people.
        /// 3) id = 0 -> Answer = Greetings to 0 people.


        public string Get(int id)
        { 
            return "Greetings to " + id + " " + "people!";
        }
    }
}
