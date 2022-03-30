using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        private BookEntity db = new BookEntity();

        // GET: Book
        public ActionResult Index()
        {
            return View(db.tblBooks.ToList());
        }

        //public ActionResult GetAll()
        //{
        //    var booklist = db.tblBooks.ToList();
        //    return Json(new { data = booklist }, JsonRequestBehavior.AllowGet);
        //}

        // GET: Book/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBook tblBook = db.tblBooks.Find(id);
            if (tblBook == null)
            {
                return HttpNotFound();
            }
            return View(tblBook);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookId,BookName,BookCategory,BookAuthor,BookNumber,Description,BookPrice,AddedDate")] tblBook tblBook)
        {
            if (ModelState.IsValid)
            {
                db.tblBooks.Add(tblBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblBook);
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBook tblBook = db.tblBooks.Find(id);
            if (tblBook == null)
            {
                return HttpNotFound();
            }
            return View(tblBook);
        }

        // POST: Book/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookId,BookName,BookCategory,BookAuthor,BookNumber,Description,BookPrice,AddedDate")] tblBook tblBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblBook);
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBook tblBook = db.tblBooks.Find(id);
            if (tblBook == null)
            {
                return HttpNotFound();
            }
            return View(tblBook);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblBook tblBook = db.tblBooks.Find(id);
            db.tblBooks.Remove(tblBook);
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
