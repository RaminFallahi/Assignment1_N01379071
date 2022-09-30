using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace Assignment1_N01379071.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// You are charging your client $5.50 / FN for web hosting and maintenance, plus HST.
        /// The input { id } represents the number of days which has elapsed.
        /// Output 3 strings which describe the total hosting cost.
        /// </summary>
        /// <returens>Returns the string amount of FN per $5.5 and the string of 13% HST and string of the total FN + HST
        /// exp: id === 2FN -> ("2 fortnights  * at 5.5 = $11") -> ("13%HST = $1.43") -> ("total 11 + 1.43 = S12.43")
        /// .</returens>
        /// <example>
        /// GET api/HostingCost/14 -> $12.43 CAD
        /// curl localhost:65011/api/HostingCost/14
        /// </example>
        /// 
        /// 
        /// “2 fortnights at $5.50/FN = $11.00 CAD”
        /// “HST 13% = $1.43 CAD”
        /// “Total = $12.43 CAD”
        public int Get(int id)
        {
            if (id >= 0 && id < 14)
            {
                return (5.5 * 113 %);
            }
            else if (id >= 14 && id < 27)
            {
                return ((5.5 * 2) * 113 %);
            }
            else if(id >= 28 && id < 42)
            {
                return ((5.5 * 3) * 113 %);
            }
        }
    }
}
