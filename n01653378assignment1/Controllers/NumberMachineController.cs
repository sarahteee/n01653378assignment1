using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01653378assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {


        /// <summary>
        /// Recieve a number, apply four mathematical operations to it
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>
        ///     GET api/route/numbermachine/10 -> "12"
        ///     GET api/route/numbermachine/-5 -> "6"
        ///     GET api/route/numbermachine/30 -> "20"
        /// </returns>
        [HttpGet]
        [Route("api/route/numbermachine/{id}")]
        public int Get(int id)
        {
            int result = (((id + 40) / 5) - 4)*2;
            
            return result;
            
           
        }
    }
}