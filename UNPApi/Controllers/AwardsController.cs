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
    public class AwardsController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var conf = AwardsManager.getAwards();

            return Ok(conf);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var conf = AwardsManager.getAwardsById(id);

            return Ok(conf);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]tbl_awards value)
        {
            var conf = AwardsManager.saveAwards(value);

            return Ok(conf);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]tbl_awards value)
        {
            var conf = AwardsManager.updateAwardsById(id, value);

            return Ok(conf);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var conf = AwardsManager.deleteAwardsById(id);

            return Ok(conf);
        }
    }
}