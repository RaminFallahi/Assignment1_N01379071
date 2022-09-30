using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01379071.Controllers
{
    public class ExampleController : ApiController
    {
        ///This is my code comment
        //GET/api/example
        //public means anyone can get to it.

        //receive a number
        //send back the same number
        //GET /api/example/4 => 4
        //GET/ api/example/{id} => id

        // beloow comments are documenting the code.

        ///<sumary>
        ///substract 5 from input number
        /// </sumary>
        /// <parm name="id"> The input number </parm>
        /// <returns>returns the input number minus five</returns>
        /// <example>
        /// GET api/example/6 => 1
        /// GET api/example/0 => -5
        /// </example>
        public int Get(int id)
        {
            int difference = id - 5;
            return difference;
        }

        /// <summary>
        /// displays a welcome message
        /// </summary>
        /// <returns>You have found the post method!</returns>
        /// <example>
        /// curl -d "" localhost:XXXXX/api/example
        /// POST api/example -> You have found the POST method!
        /// </example>
        public string Post()
        {
            return "You have found post method!";
        }

        //POST /api/example/{id}
        //curl -d "" localhost:XXX
        public int Post(int id)
        {
            return 6;
        }

    }
}
