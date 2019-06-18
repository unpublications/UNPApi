using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DoctorPortalApi.Models;

namespace DoctorPortalApi.Manager
{
    public class EVideoManager
    {
        internal static List<tbl_evideo> getEVideo()
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_evideo.ToList();

                return list;

            }
        }

        internal static tbl_evideo getEVideoById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_evideo.Where(o => o.uniq_id == id).FirstOrDefault();

                return list;

            }
        }

        internal static tbl_evideo saveEVideo(tbl_evideo value)
        {
            using (var db = new UNPEntities())
            {
                db.tbl_evideo.Add(value);
                db.SaveChanges();

                return value;

            }
        }

        internal static tbl_evideo updateEVideoById(int id, tbl_evideo value)
        {
            using (var db = new UNPEntities())
            {

                db.Entry(value).State = EntityState.Modified;
                db.SaveChanges();

                return value;

            }
        }

        internal static String deleteEVideoById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = getEVideoById(id);

                db.tbl_evideo.Attach(list);
                db.tbl_evideo.Remove(list);
                db.SaveChanges();

                return "Row Deleted";

            }
        }
    }
}