using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DoctorPortalApi.Models;

namespace DoctorPortalApi.Manager
{
    public class OrganizingCommiteManager
    {
        internal static List<tbl_ogc> getOrganizingCommite()
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_ogc.ToList();

                return list;

            }
        }

        internal static tbl_ogc getOrganizingCommiteById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_ogc.Where(o => o.uniq_id == id).FirstOrDefault();

                return list;

            }
        }

        internal static tbl_ogc saveOrganizingCommite(tbl_ogc value)
        {
            using (var db = new UNPEntities())
            {
                db.tbl_ogc.Add(value);
                db.SaveChanges();

                return value;

            }
        }

        internal static tbl_ogc updateOrganizingCommiteById(int id, tbl_ogc value)
        {
            using (var db = new UNPEntities())
            {

                db.Entry(value).State = EntityState.Modified;
                db.SaveChanges();

                return value;

            }
        }

        internal static String deleteOrganizingCommiteById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = getOrganizingCommiteById(id);

                db.tbl_ogc.Remove(list);
                db.SaveChanges();

                return "Row Deleted";

            }
        }
    }
}