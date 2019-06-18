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
    public class EVideoController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var conf = EVideoManager.getEVideo();

            return Ok(conf);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var conf = EVideoManager.getEVideoById(id);

            return Ok(conf);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]tbl_evideo value)
        {
            var conf = EVideoManager.saveEVideo(value);

            return Ok(conf);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]tbl_evideo value)
        {
            var conf = EVideoManager.updateEVideoById(id, value);

            return Ok(conf);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var conf = EVideoManager.deleteEVideoById(id);

            return Ok(conf);
        }
    }
}