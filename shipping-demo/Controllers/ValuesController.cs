using shipping_demo.Context;
using shipping_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace shipping_demo.Controllers
{
    public class ValuesController : ApiController
    {

        DbContext _context = new DbContext();
        // GET api/values
        public IHttpActionResult Get()
        {
            var query = from user in _context.User select user;
            return Ok(query.ToList());
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
