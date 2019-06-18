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
    public class ProgramScheduleController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var conf = ProgramScheduleManager.getProgramSchedule();

            return Ok(conf);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var conf = ProgramScheduleManager.getProgramScheduleById(id);

            return Ok(conf);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]tbl_ps value)
        {
            var conf = ProgramScheduleManager.saveProgramSchedule(value);

            return Ok(conf);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]tbl_ps value)
        {
            var conf = ProgramScheduleManager.updateProgramScheduleById(id, value);

            return Ok(conf);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var conf = ProgramScheduleManager.deleteProgramScheduleById(id);

            return Ok(conf);
        }
    }
}