using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01653378assignment1.Controllers
{
    public class HostingCostController : ApiController
    {

        /// <summary>
        /// Recieve the number of days and output cost of fortnight, HST and total
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>
        ///     GET api/route/hostingcost/0 -> "1 fortnights at $5.50/FN = $5.50 CAD", "HST 13% = $0.72 CAD", "Total = $6.22 CAD"
        ///     GET api/route/hostingcost/14 -> "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        ///     GET api/route/hostingcost/15 -> "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        ///     GET api/route/hostingcost/21 -> "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        ///     GET api/route/hostingcost/28 -> "3 fortnights at $5.50/FN = $16.50 CAD", "HST 13% = $2.14 CAD", "Total = $18.64 CAD"
        /// </returns>
        [HttpGet]
        [Route("api/route/hostingcost/{id}")]
        public decimal Get(int id)
        {
            int numofDays = id;
            int fortnight = numofDays / 14;
            decimal baseRate = (decimal)5.50;
            decimal fortnightPrice = (fortnight * (decimal)5.50 + (decimal)baseRate);
            decimal hstRate = (decimal)0.13;
            decimal hstTax = ((decimal)fortnightPrice * (decimal)hstRate);
            decimal totalCost = Math.Round(((decimal)fortnightPrice + (decimal)hstTax),2);


            {
                return totalCost;
                //return [] {"1 fortnights at $5.50/FN = $" + baseRate + "CAD", "HST 13% = $" + hstTax + "CAD", "Total =" + totalCost + "CAD"};
                //If you run the code, the output numbers are correct but I can't figure out how to get a multiline output
            }    
                
        }

    }
}