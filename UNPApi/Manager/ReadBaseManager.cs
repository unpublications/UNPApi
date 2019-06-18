using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DoctorPortalApi.Models;

namespace DoctorPortalApi.Manager
{
    public class ReadBaseManager
    {
        internal static List<tbl_rb> getReadBase()
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_rb.ToList();

                return list;

            }
        }

        internal static tbl_rb getReadBaseById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_rb.Where(o => o.uniq_id == id).FirstOrDefault();

                return list;

            }
        }

        internal static tbl_rb saveReadBase(tbl_rb value)
        {
            using (var db = new UNPEntities())
            {
                db.tbl_rb.Add(value);
                db.SaveChanges();

                return value;

            }
        }

        internal static tbl_rb updateReadBaseById(int id, tbl_rb value)
        {
            using (var db = new UNPEntities())
            {

                db.Entry(value).State = EntityState.Modified;
                db.SaveChanges();

                return value;

            }
        }

        internal static String deleteReadBaseById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = getReadBaseById(id);

                db.tbl_rb.Attach(list);
                db.tbl_rb.Remove(list);
                db.SaveChanges();

                return "Row Deleted";

            }
        }
    }
}