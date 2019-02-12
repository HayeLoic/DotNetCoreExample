using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreExampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirthDatesController : ControllerBase
    {
        private readonly DateTime[] birthDates = { new DateTime(1999, 11, 8), new DateTime(2012, 2, 23) };

        // GET api/birthDates
        [HttpGet]
        public ActionResult<IEnumerable<DateTime>> Get()
        {
            return this.birthDates;
        }

        // GET api/birthDates/2
        [HttpGet("{id}")]
        public ActionResult<DateTime> Get(int id)
        {
            if (id > 0 && id <= this.birthDates.Length)
            {
                return this.birthDates[id - 1];
            }
            else
            {
                return null;
            }
        }

        // POST api/birthDates
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/birthDates/2
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/birthDates/2
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
