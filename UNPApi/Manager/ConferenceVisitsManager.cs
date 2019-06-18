using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DoctorPortalApi.Models;

namespace DoctorPortalApi.Manager
{
    public class ConferenceVisitsManager
    {
        internal static List<tbl_site_visits> getConferenceVisits()
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_site_visits.ToList();

                return list;

            }
        }

        internal static tbl_site_visits getConferenceVisitsById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_site_visits.Where(o => o.uniq_id == id).FirstOrDefault();

                return list;

            }
        }

        internal static tbl_site_visits saveConferenceVisits(tbl_site_visits value)
        {
            using (var db = new UNPEntities())
            {
                db.tbl_site_visits.Add(value);
                db.SaveChanges();

                return value;

            }
        }

        internal static tbl_site_visits updateConferenceVisitsById(int id, tbl_site_visits value)
        {
            using (var db = new UNPEntities())
            {

                db.Entry(value).State = EntityState.Modified;
                db.SaveChanges();

                return value;

            }
        }

        internal static String deleteConferenceVisitsById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = getConferenceVisitsById(id);

                db.tbl_site_visits.Remove(list);
                db.SaveChanges();

                return "Row Deleted";

            }
        }
    }
}