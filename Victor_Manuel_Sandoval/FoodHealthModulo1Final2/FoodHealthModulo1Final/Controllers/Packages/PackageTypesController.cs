using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FoodHealthModulo1Final.Context;
using FoodHealthModulo1Final.Models.Packages;

namespace FoodHealthModulo1Final.Controllers.Packages
{
    public class PackageTypesController : Controller
    {
        private FoodHealthModulo1FinalContext db = new FoodHealthModulo1FinalContext();

        // GET: PackageTypes
        public ActionResult Index()
        {
            return View(db.PackageTypes.ToList());
        }

        // GET: PackageTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PackageType packageType = db.PackageTypes.Find(id);
            if (packageType == null)
            {
                return HttpNotFound();
            }
            return View(packageType);
        }

        // GET: PackageTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PackageTypes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PackageTypeID,Duration")] PackageType packageType)
        {
            if (ModelState.IsValid)
            {
                db.PackageTypes.Add(packageType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(packageType);
        }

        // GET: PackageTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PackageType packageType = db.PackageTypes.Find(id);
            if (packageType == null)
            {
                return HttpNotFound();
            }
            return View(packageType);
        }

        // POST: PackageTypes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PackageTypeID,Duration")] PackageType packageType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(packageType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(packageType);
        }

        // GET: PackageTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PackageType packageType = db.PackageTypes.Find(id);
            if (packageType == null)
            {
                return HttpNotFound();
            }
            return View(packageType);
        }

        // POST: PackageTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PackageType packageType = db.PackageTypes.Find(id);
            db.PackageTypes.Remove(packageType);
            try
            {
                db.SaveChanges();
            }
            catch
            {

            }
            
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
