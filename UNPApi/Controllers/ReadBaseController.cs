using DoctorPortalApi.Manager;
using DoctorPortalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoctorPortalApi.Controllers
{
    public class ReadBaseController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var conf = ReadBaseManager.getReadBase();

            return Ok(conf);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var conf = ReadBaseManager.getReadBaseById(id);

            return Ok(conf);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]tbl_rb value)
        {
            var conf = ReadBaseManager.saveReadBase(value);

            return Ok(conf);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]tbl_rb value)
        {
            var conf = ReadBaseManager.updateReadBaseById(id, value);

            return Ok(conf);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var conf = ReadBaseManager.deleteReadBaseById(id);

            return Ok(conf);
        }
    }
}