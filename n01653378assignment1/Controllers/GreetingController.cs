using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01653378assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        

        /// <summary>
        /// Output a greeting
        /// </summary>
        /// <returns>
        ///     POST api/route/Greeting -> "Hello World!"
        /// </returns>
        [HttpPost]
        [Route("api/route/greeting")]
        public string Greeting()
        {
            string greeting = "Hello World";
            return greeting;
        }


        /// <summary>
        /// Recieve a number, output a greeting for that number of people
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>
        ///     GET api/route/Greeting/3 -> "Greetings to 3 people!"
        ///     GET api/route/Greeting/6 -> "Greetings to 6 people!"
        ///     GET api/route/Greeting/0 -> "Greetings to 0 people!"
        /// </returns>
        [HttpGet]
        [Route("api/route/greeting/{id}")]
        public string Greeting(int id)
        {
            int greeting = id;
            return "Greetings to " + id + " people!";
        }
    }
}
 
        