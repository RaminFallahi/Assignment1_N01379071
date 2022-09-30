using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01379071.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// square the integer input
        /// </summary>
        /// <returens>Returns square of the integer input {id}.</returens>
        /// <example>
        /// GET api/square/10 -> 100
        /// curl localhost:65011/api/square/10
        /// </example>
        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
