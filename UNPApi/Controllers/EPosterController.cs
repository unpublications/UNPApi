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
    public class EPosterController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var conf = EPosterManager.getEPoster();

            return Ok(conf);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var conf = EPosterManager.getEPosterById(id);

            return Ok(conf);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]tbl_eposter value)
        {
            var conf = EPosterManager.saveEPoster(value);

            return Ok(conf);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]tbl_eposter value)
        {
            var conf = EPosterManager.updateEPosterById(id, value);

            return Ok(conf);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var conf = EPosterManager.deleteEPosterById(id);

            return Ok(conf);
        }
    }
}