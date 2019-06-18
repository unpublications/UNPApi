using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DoctorPortalApi.Models;

namespace DoctorPortalApi.Manager
{
    public class ProgramScheduleManager
    {
        internal static List<tbl_ps> getProgramSchedule()
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_ps.ToList();

                return list;

            }
        }

        internal static tbl_ps getProgramScheduleById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_ps.Where(o => o.uniq_id == id).FirstOrDefault();

                return list;

            }
        }

        internal static tbl_ps saveProgramSchedule(tbl_ps value)
        {
            using (var db = new UNPEntities())
            {
                db.tbl_ps.Add(value);
                db.SaveChanges();

                return value;

            }
        }

        internal static tbl_ps updateProgramScheduleById(int id, tbl_ps value)
        {
            using (var db = new UNPEntities())
            {

                db.Entry(value).State = EntityState.Modified;
                db.SaveChanges();

                return value;

            }
        }

        internal static String deleteProgramScheduleById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = getProgramScheduleById(id);

                db.tbl_ps.Attach(list);
                db.tbl_ps.Remove(list);
                db.SaveChanges();

                return "Row Deleted";

            }
        }
    }
}