using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DoctorPortalApi.Models;

namespace DoctorPortalApi.Manager
{
    public class AwardsManager
    {
        internal static List<tbl_awards> getAwards()
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_awards.ToList();

                return list;

            }
        }

        internal static tbl_awards getAwardsById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_awards.Where(o => o.uniq_id == id).FirstOrDefault();

                return list;

            }
        }

        internal static tbl_awards saveAwards(tbl_awards value)
        {
            using (var db = new UNPEntities())
            {
                db.tbl_awards.Add(value);
                db.SaveChanges();

                return value;

            }
        }

        internal static tbl_awards updateAwardsById(int id, tbl_awards value)
        {
            using (var db = new UNPEntities())
            {

                db.Entry(value).State = EntityState.Modified;
                db.SaveChanges();

                return value;

            }
        }

        internal static String deleteAwardsById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = getAwardsById(id);

                db.tbl_awards.Attach(list);
                db.tbl_awards.Remove(list);
                db.SaveChanges();

                return "Row Deleted";

            }
        }
    }
}