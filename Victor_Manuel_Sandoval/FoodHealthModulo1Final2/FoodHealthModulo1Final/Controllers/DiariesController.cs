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
    public class DiariesController : Controller
    {
        private FoodHealthModulo1FinalContext db = new FoodHealthModulo1FinalContext();

        // GET: Diaries
        public ActionResult Index()
        {
            var diaries = db.Diaries.Include(d => d.AppointmentType);
            return View(diaries.ToList());
        }

        // GET: Diaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diary diary = db.Diaries.Find(id);
            if (diary == null)
            {
                return HttpNotFound();
            }
            return View(diary);
        }

        // GET: Diaries/Create
        public ActionResult Create()
        {
            ViewBag.AppointmentTypeID = new SelectList(db.AppointmentTypes, "AppointmentTypeID", "NameAppointment");
            return View();
        }

        // POST: Diaries/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DiaryID,AppointmentTypeID,DateOfAppointment,NameAppointment")] Diary diary)
        {
            if (ModelState.IsValid)
            {
                db.Diaries.Add(diary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AppointmentTypeID = new SelectList(db.AppointmentTypes, "AppointmentTypeID", "NameAppointment", diary.AppointmentTypeID);
            return View(diary);
        }

        // GET: Diaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diary diary = db.Diaries.Find(id);
            if (diary == null)
            {
                return HttpNotFound();
            }
            ViewBag.AppointmentTypeID = new SelectList(db.AppointmentTypes, "AppointmentTypeID", "NameAppointment", diary.AppointmentTypeID);
            return View(diary);
        }

        // POST: Diaries/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DiaryID,AppointmentTypeID,DateOfAppointment")] Diary diary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AppointmentTypeID = new SelectList(db.AppointmentTypes, "AppointmentTypeID", "NameAppointment", diary.AppointmentTypeID);
            return View(diary);
        }

        // GET: Diaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diary diary = db.Diaries.Find(id);
            if (diary == null)
            {
                return HttpNotFound();
            }
            return View(diary);
        }

        // POST: Diaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diary diary = db.Diaries.Find(id);
            db.Diaries.Remove(diary);
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
