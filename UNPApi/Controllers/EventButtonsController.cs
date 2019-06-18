﻿using DoctorPortalApi.Manager;
using DoctorPortalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoctorPortalApi.Controllers
{
    public class EventButtonsController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var conf = EventButtonsManager.getEventButtons();

            return Ok(conf);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var conf = EventButtonsManager.getEventButtonsById(id);

            return Ok(conf);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]tbl_event_buttons value)
        {
            var conf = EventButtonsManager.saveEventButtons(value);

            return Ok(conf);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]tbl_event_buttons value)
        {
            var conf = EventButtonsManager.updateEventButtonsById(id, value);

            return Ok(conf);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var conf = EventButtonsManager.deleteEventButtonsById(id);

            return Ok(conf);
        }
    }
}