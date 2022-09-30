using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01379071.Controllers
{
    public class GreetingIdController : ApiController
    {

        /// <summary>
        /// add integer into a string
        /// </summary>
        /// <returens>Returns the string “Greetings to {id} people!” where id is an integer value.</returens>
        /// <example>
        /// GET /api/greetingId/ -> "greeting to " + int(id) + " people!"
        /// curl localhost:65011/api/greetingId/3
        /// </example>
        public string Get(int id)
        {
            return "Greeting to " + id + " people!";
        }
    }
}
