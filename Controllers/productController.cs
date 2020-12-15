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
    public class productController : Controller
    {
        private Entities3 db = new Entities3();

        // GET: product
        public ActionResult Index()
        {
            var product_tables = db.product_tables.Include(p => p.categories_table);
            return View(product_tables.ToList());
        }

        // GET: product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product_table product_table = db.product_tables.Find(id);
            if (product_table == null)
            {
                return HttpNotFound();
            }
            return View(product_table);
        }

        // GET: product/Create
        public ActionResult Create()
        {
            ViewBag.Cat_Id = new SelectList(db.categories_tables, "Cat_id", "Cat_name");
            return View();
        }

        // POST: product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Pro_id,Pro_details,Pro_price,Pro_qty,Pro_name,Cat_Id")] product_table product_table)
        {
            if (ModelState.IsValid)
            {
                db.product_tables.Add(product_table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cat_Id = new SelectList(db.categories_tables, "Cat_id", "Cat_name", product_table.Cat_Id);
            return View(product_table);
        }

        // GET: product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product_table product_table = db.product_tables.Find(id);
            if (product_table == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cat_Id = new SelectList(db.categories_tables, "Cat_id", "Cat_name", product_table.Cat_Id);
            return View(product_table);
        }

        // POST: product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Pro_id,Pro_details,Pro_price,Pro_qty,Pro_name,Cat_Id")] product_table product_table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cat_Id = new SelectList(db.categories_tables, "Cat_id", "Cat_name", product_table.Cat_Id);
            return View(product_table);
        }

        // GET: product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product_table product_table = db.product_tables.Find(id);
            if (product_table == null)
            {
                return HttpNotFound();
            }
            return View(product_table);
        }

        // POST: product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product_table product_table = db.product_tables.Find(id);
            db.product_tables.Remove(product_table);
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
