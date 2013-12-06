using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPITest.Controllers
{
    public class SnackUserController : ApiController
    {
        // GET api/snackuser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/snackuser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/snackuser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/snackuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/snackuser/5
        public void Delete(int id)
        {
        }
    }
}
