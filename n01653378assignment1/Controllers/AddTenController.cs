using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01653378assignment1.Controllers
{

    public class AddTenController : ApiController
    {


        /// <summary>
        /// Recieve a number, output the sum when ten is added to it
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>
        ///     GET api/route/AddTen/21 -> "31"
        ///     GET api/route/AddTen/0 -> "10"
        ///     GET api/route/AddTen/-9 -> "1"
        /// </returns>
        [HttpGet]
        [Route("api/route/addten/{id}")]
        public int AddTen(int id) 
        {
            int sum = id + 10;
            return sum;
        }
    }
} 