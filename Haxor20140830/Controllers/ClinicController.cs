using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Haxor20140830.Controllers
{
    public class ClinicController : ApiController
    {
        // GET: api/Clinic
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Clinic/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Clinic
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clinic/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clinic/5
        public void Delete(int id)
        {
        }
    }
}
