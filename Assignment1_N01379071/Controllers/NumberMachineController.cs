using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01379071.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// Create a method which has an input {id}, and applies four mathematical operations to it (((id + id) * id) - id) / id.
        /// </summary>
        /// <returens>Returns int(id) after four mathematical formula operations to it 
        /// exp: id === 2 -> (2 + 2 = 4) -> (4 * 2 = 8) -> (8 - 2 = 6) -> (6 / 2 = 3)
        /// .</returens>
        /// <example>
        /// GET api/NumberMachine/-5 -> -11
        /// curl localhost:65011/api/NumberMachine/-5
        /// </example>
        public int Get(int id)
        {
            int result = (((id + id) * id) - id) / id;
            return result;
        }
    }
}
