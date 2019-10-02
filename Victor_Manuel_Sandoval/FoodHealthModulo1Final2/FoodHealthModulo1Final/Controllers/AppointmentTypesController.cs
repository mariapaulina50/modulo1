using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FoodHealthModulo1Final.Context;
using FoodHealthModulo1Final.Models.Diary;

namespace FoodHealthModulo1Final.Controllers
{
    public class AppointmentTypesController : Controller
    {
        private FoodHealthModulo1FinalContext db = new FoodHealthModulo1FinalContext();

        // GET: AppointmentTypes
        public ActionResult Index()
        {
            return View(db.AppointmentTypes.ToList());
        }

        // GET: AppointmentTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentType appointmentType = db.AppointmentTypes.Find(id);
            if (appointmentType == null)
            {
                return HttpNotFound();
            }
            return View(appointmentType);
        }

        // GET: AppointmentTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppointmentTypes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AppointmentTypeID,NameAppointment")] AppointmentType appointmentType)
        {
            if (ModelState.IsValid)
            {
                db.AppointmentTypes.Add(appointmentType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appointmentType);
        }

        // GET: AppointmentTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentType appointmentType = db.AppointmentTypes.Find(id);
            if (appointmentType == null)
            {
                return HttpNotFound();
            }
            return View(appointmentType);
        }

        // POST: AppointmentTypes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AppointmentTypeID,NameAppointment")] AppointmentType appointmentType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointmentType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointmentType);
        }

        // GET: AppointmentTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentType appointmentType = db.AppointmentTypes.Find(id);
            if (appointmentType == null)
            {
                return HttpNotFound();
            }
            return View(appointmentType);
        }

        // POST: AppointmentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppointmentType appointmentType = db.AppointmentTypes.Find(id);
            db.AppointmentTypes.Remove(appointmentType);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
