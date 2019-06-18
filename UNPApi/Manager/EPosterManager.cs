using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DoctorPortalApi.Models;

namespace DoctorPortalApi.Manager
{
    public class EPosterManager
    {
        internal static List<tbl_eposter> getEPoster()
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_eposter.ToList();

                return list;

            }
        }

        internal static tbl_eposter getEPosterById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_eposter.Where(o => o.uniq_id == id).FirstOrDefault();

                return list;

            }
        }

        internal static tbl_eposter saveEPoster(tbl_eposter value)
        {
            using (var db = new UNPEntities())
            {
                db.tbl_eposter.Add(value);
                db.SaveChanges();

                return value;

            }
        }

        internal static tbl_eposter updateEPosterById(int id, tbl_eposter value)
        {
            using (var db = new UNPEntities())
            {

                db.Entry(value).State = EntityState.Modified;
                db.SaveChanges();

                return value;

            }
        }

        internal static String deleteEPosterById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = getEPosterById(id);

                db.tbl_eposter.Attach(list);
                db.tbl_eposter.Remove(list);
                db.SaveChanges();

                return "Row Deleted";

            }
        }
    }
}