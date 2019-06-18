using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DoctorPortalApi.Models;

namespace DoctorPortalApi.Manager
{
    public class EventButtonsManager
    {
        internal static List<tbl_event_buttons> getEventButtons()
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_event_buttons.ToList();

                return list;

            }
        }

        internal static tbl_event_buttons getEventButtonsById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = db.tbl_event_buttons.Where(o => o.uniq_id == id).FirstOrDefault();

                return list;

            }
        }

        internal static tbl_event_buttons saveEventButtons(tbl_event_buttons value)
        {
            using (var db = new UNPEntities())
            {
                db.tbl_event_buttons.Add(value);
                db.SaveChanges();

                return value;

            }
        }

        internal static tbl_event_buttons updateEventButtonsById(int id, tbl_event_buttons value)
        {
            using (var db = new UNPEntities())
            {

                db.Entry(value).State = EntityState.Modified;
                db.SaveChanges();

                return value;

            }
        }

        internal static String deleteEventButtonsById(int id)
        {
            using (var db = new UNPEntities())
            {
                var list = getEventButtonsById(id);

                db.tbl_event_buttons.Remove(list);
                db.SaveChanges();

                return "Row Deleted";

            }
        }
    }
}