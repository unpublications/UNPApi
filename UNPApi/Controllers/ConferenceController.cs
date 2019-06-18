using DoctorPortalApi.Manager;
using DoctorPortalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace DoctorPortalApi.Controllers
{
    public class ConferenceController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var conf = ConferenceManager.getConferences();

            return Ok(conf);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var conf = ConferenceManager.getConferenceById(id);

            return Ok(conf);
        }

        // POST api/<controller>
        public IHttpActionResult Post(tbl_conference value)
        {
            var conf = ConferenceManager.saveConference(value);

            return Ok(conf);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]tbl_conference value)
        {
            var conf = ConferenceManager.updateConferenceById(id, value);

            return Ok(conf);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var conf = ConferenceManager.deleteConferenceById(id);

            return Ok(conf);
        }
    }
}