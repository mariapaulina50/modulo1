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
    public class EmployeesController : Controller
    {
        private FoodHealthModulo1Context db = new FoodHealthModulo1Context();

        // GET: Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.DocumentTypes);
            var employees1 = db.Employees.Include(e => e.Role);
            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.DocumentTypeId = new SelectList(db.DocumentTypes, "DocumentTypeId", "DocumentName");
            ViewBag.RoleID = new SelectList(db.Roles, "RoleID", "RoleName");
            return View();
        }

        // POST: Employees/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeId,Document,RoleID,RoleName,FirstName,LastName,Salary,DateOfBirth,Email,Usuario,Clave,DocumentTypeId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DocumentTypeId = new SelectList(db.DocumentTypes, "DocumentTypeId", "DocumentName", employee.DocumentTypeId);
            ViewBag.RoleID = new SelectList(db.Roles, "RoleID", "RoleName", employee.RoleID);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.DocumentTypeId = new SelectList(db.DocumentTypes, "DocumentTypeId", "DocumentName", employee.DocumentTypeId);
            ViewBag.RoleID = new SelectList(db.Roles, "RoleID", "RoleName", employee.RoleID);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeId,RoleID,Document,RoleName,FirstName,LastName,Salary,DateOfBirth,Email,Usuario,Clave,DocumentTypeId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DocumentTypeId = new SelectList(db.DocumentTypes, "DocumentTypeId", "DocumentName", employee.DocumentTypeId);
            ViewBag.RoleID = new SelectList(db.Roles, "RoleID", "RoleName", employee.RoleID);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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
