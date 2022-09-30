using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01379071.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// String "Hello World!"
        /// </summary>
        /// <returens>Returns the string “Hello World!”</returens>
        /// <example>
        /// curl -d "" localhost:65011/api/greeting/
        /// </example>

        public string Post()
        {
            return "Hello World!";
        }
    }
}
