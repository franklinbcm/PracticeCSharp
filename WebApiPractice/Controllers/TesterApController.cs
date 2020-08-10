using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiPractice.Controllers
{
    public class TesterApController : ApiController
    {
        // GET: api/TesterAp
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TesterAp/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TesterAp
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TesterAp/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TesterAp/5
        public void Delete(int id)
        {
        }
    }
}
