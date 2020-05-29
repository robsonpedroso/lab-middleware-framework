using System.Collections.Generic;
using System.Web.Http;

namespace MiddlewareFramework.Controllers
{
    public class MiddlewareController : ApiController
    {
        // GET: api/Middleware
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Middleware/5
        public string Get(int id)
        {

            return "value";
        }

        // POST: api/Middleware
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Middleware/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Middleware/5
        public void Delete(int id)
        {
        }
    }
}
