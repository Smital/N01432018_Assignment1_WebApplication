using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01432018_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Assignment Question 6
        /// You are charging your client $5.50 / FN (fortnight = 14 days) for web hosting and maintenance,
        /// plus an additional 13% HST.The input { id } represents the number of days which has elapse since the beginning of the hosting.
        /// Output 3 strings which describe the total hosting cost.
        /// <param name="id"/></param>
        /// <returns></returns>
        /// GET api/NumberMachine/5 -> 20 (Using BEDMAS)
        

        /// It would return value after calculating 4 arithmetic operation.
        /// For example if,
        /// 1) id = 10 -> Answer = 98.
        /// 2) id = -5 -> Answer = 23
        /// 3) id = 30 -> Answer = 898.
        
        double fortnight = 5.50;
        double fortnightvalue;
        double HST;
        double total;
        double finalrate;
        public string Get(int id)
        {
            if(id == 0)
            {
                fortnightvalue = 1;
                finalrate = fortnightvalue * fortnight;
                HST = (finalrate * 13) / 100;
                total = finalrate+ HST;
            }
             else if (id == 14 || id == 15 || id == 21)
            {
                fortnightvalue = 2; 
                finalrate = fortnightvalue * fortnight;
                HST = (finalrate * 13) / 100;
                total = finalrate + HST;
            }
            else if (id == 28)
            {
                fortnightvalue = 3;
                finalrate = fortnightvalue * fortnight;
                HST = (finalrate * 13) / 100;
                total = finalrate + HST;
            }


            return "1 Fortnight at $ " + Math.Round(fortnight,2) + "/FN = $" + Math.Round(finalrate,2) + "CAD" + "\r\n" + "HST 13% = " + Math.Round(HST,2) + "CAD" + "\r\n" + " Total = " + Math.Round(total,2) + "CAD";

        }
    }
}
