using DoctorPortalApi.Manager;
using DoctorPortalApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
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

        #region UploadFile
        [System.Web.Http.HttpPost]
        public IHttpActionResult FileUpload()
        {
            if (HttpContext.Current.Request.Files.Count > 0)
            {
                var uploadFile = HttpContext.Current.Request.Files[0];
                //  HttpContext.Current.Server.MapPath("~/UserImage")
                string filePath = Path.Combine(HttpContext.Current.Server.MapPath("~/Uploads"),
                                               Path.GetFileName(uploadFile.FileName));
                string uniqueFileName = string.Concat(//Path.GetFileNameWithoutExtension(filePath),
                                         DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                                         Path.GetExtension(filePath));

                string filePathFinal = Path.Combine(HttpContext.Current.Server.MapPath("~/Uploads"), uniqueFileName);
                uploadFile.SaveAs(filePathFinal);
                return Content(HttpStatusCode.OK, uniqueFileName);
                //  return Content(HttpStatusCode.OK, "http://localhost:53007/Uploads/" + uniqueFileName);
            }
            else
            {
                return NotFound();
            }

        }
        #endregion
    }
}