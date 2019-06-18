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
    public class ConferenceVisitsController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var conf = ConferenceVisitsManager.getConferenceVisits();

            return Ok(conf);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var conf = ConferenceVisitsManager.getConferenceVisitsById(id);

            return Ok(conf);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]tbl_site_visits value)
        {
            var conf = ConferenceVisitsManager.saveConferenceVisits(value);

            return Ok(conf);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]tbl_site_visits value)
        {
            var conf = ConferenceVisitsManager.updateConferenceVisitsById(id, value);

            return Ok(conf);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var conf = ConferenceVisitsManager.deleteConferenceVisitsById(id);

            return Ok(conf);
        }
    }
}