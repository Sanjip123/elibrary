using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using elibrary;

namespace elibrary.Controllers
{
        public class categoryController : Controller
    {
        private Entities3 db = new Entities3();

        // GET: category
        public ActionResult Index()
        {
            return View(db.categories_tables.ToList());
        }

        // GET: category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categories_table categories_table = db.categories_tables.Find(id);
            if (categories_table == null)
            {
                return HttpNotFound();
            }
            return View(categories_table);
        }

        // GET: category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cat_id,Cat_name")] categories_table categories_table)
        {
            if (ModelState.IsValid)
            {
                db.categories_tables.Add(categories_table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categories_table);
        }

        // GET: category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categories_table categories_table = db.categories_tables.Find(id);
            if (categories_table == null)
            {
                return HttpNotFound();
            }
            return View(categories_table);
        }

        // POST: category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cat_id,Cat_name")] categories_table categories_table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categories_table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categories_table);
        }

        // GET: category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categories_table categories_table = db.categories_tables.Find(id);
            if (categories_table == null)
            {
                return HttpNotFound();
            }
            return View(categories_table);
        }

        // POST: category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            categories_table categories_table = db.categories_tables.Find(id);
            db.categories_tables.Remove(categories_table);
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
