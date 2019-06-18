using DoctorPortalApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DoctorPortalApi.Manager
{
    public class ConferenceManager
    {
        internal static List<tbl_conference> getConferences()
        {
            using (var db = new UNPEntities()) {
                var list = db.tbl_conference.ToList();

                return list;

            }

        }

        internal static tbl_conference getConferenceById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_conference.Where(o=> o.uniq_id == id).FirstOrDefault();

                return list;

            }
        }

        internal static tbl_conference saveConference(tbl_conference details)
        {
            using (var db = new UNPEntities())
            {
                db.tbl_conference.Add(details);
                db.SaveChanges();

                return details;

            }
        }

        internal static tbl_conference updateConferenceById(int id, tbl_conference details)
        {
            using (var db = new UNPEntities())
            {

                db.Entry(details).State = EntityState.Modified;
                db.SaveChanges();

                return details;

            }
        }

        internal static String deleteConferenceById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = getConferenceById(id);

                db.tbl_conference.Remove(list);
                db.SaveChanges();

                return "Row Deleted";

            }
        }
    }
}