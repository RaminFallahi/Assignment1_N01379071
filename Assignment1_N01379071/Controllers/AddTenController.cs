using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01379071.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Add 10 on the integer input
        /// </summary>
        /// <returens>Returns 10 more than the integer input {id}.</returens>
        /// <example>
        /// GET api/AddTen/10 -> 20
        /// curl localhost:65011/api/AddTen/10
        /// </example>
        public int Get(int id)
        {
            int difference = id + 10;
            return difference;
        }
    }
}
