using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01653378assignment1.Controllers
{
    public class SquareController : ApiController
    {


        /// <summary>
        /// Recieve a number, output the square of the number
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>
        ///     GET api/route/square/2 -> "31"
        ///     GET api/route/square/-2 -> "10"
        ///     GET api/route/square/10 -> "1"
        /// </returns>
        [HttpGet]
        [Route("api/route/square/{id}")]
        public int Get(int id) 
        {
            int square = id * id;
            return square;

        }
    }
}
