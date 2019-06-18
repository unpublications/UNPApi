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
    public class OrganizingCommiteController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var conf = OrganizingCommiteManager.getOrganizingCommite();

            return Ok(conf);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var conf = OrganizingCommiteManager.getOrganizingCommiteById(id);

            return Ok(conf);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]tbl_ogc value)
        {
            var conf = OrganizingCommiteManager.saveOrganizingCommite(value);

            return Ok(conf);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]tbl_ogc value)
        {
            var conf = OrganizingCommiteManager.updateOrganizingCommiteById(id, value);

            return Ok(conf);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var conf = OrganizingCommiteManager.deleteOrganizingCommiteById(id);

            return Ok(conf);
        }
    }
}