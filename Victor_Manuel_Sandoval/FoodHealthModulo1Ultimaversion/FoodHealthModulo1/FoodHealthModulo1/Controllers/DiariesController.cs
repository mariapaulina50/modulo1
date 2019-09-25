using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FoodHealthModulo1.Context;
using FoodHealthModulo1.Models;

namespace FoodHealthModulo1.Controllers
{
    public class DiariesController : Controller
    {
        private FoodHealthModulo1Context db = new FoodHealthModulo1Context();

        // GET: Diaries
        public ActionResult Index()
        {
            return View(db.Diaries.ToList());
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
            return View();
        }

        // POST: Diaries/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DiaryID,Fecha,Sede,Nutricionista,Ciudad,Hora_cita")] Diary diary)
        {
            if (ModelState.IsValid)
            {
                db.Diaries.Add(diary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

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
            return View(diary);
        }

        // POST: Diaries/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DiaryID,Fecha,Sede,Nutricionista,Ciudad,Hora_cita")] Diary diary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
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
