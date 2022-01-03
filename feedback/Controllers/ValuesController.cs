using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using feedback.Models;
using feedback.Entities;

namespace feedback.Controllers
{
    
    public class ValuesController : ApiController
    {
        private FeedbackDBContext db = new FeedbackDBContext();

        // GET api/v1
        [Route("api/v1")]
        public IQueryable<User> Get()
        {
            return db.Users;
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
