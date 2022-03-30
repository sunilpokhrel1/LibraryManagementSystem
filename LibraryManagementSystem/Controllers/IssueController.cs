//using LibraryManagementSystem.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace LibraryManagementSystem.Controllers
//{
//    public class IssueController : Controller
//    {
//        StudentEntity db = new StudentEntity();

//        BookEntity Db = new BookEntity();



//        // GET: Issue
//        public ActionResult Index()
//        {
//            return View(IDb.tblIssues.ToList());
//        }

//        // GET: Issue/Details/5

//        // GET: Issue
//        // GET: Issue
//        public ActionResult Issue()
//        {
//            return View();
//        }

//[HttpGet]
//public ActionResult GetStudentId(int StudentId)
//{
//    var StudId = (from s in db.tblStudents where s.StudentId == StudentId select s.StudentName).ToList();
//    return Json(StudId, JsonRequestBehavior.AllowGet);


//}

//[HttpGet]
//public ActionResult GetBookId(int BookId)
//{
//    var BId = (from s in Db.tblBooks where s.BookId == BookId select s.BookName).ToList();
//    return Json(BId, JsonRequestBehavior.AllowGet);


//}
//[HttpPost]
//public ActionResult Save(tblIssue issue)
//{
//    if (ModelState.IsValid)
//    {


//        IDb.tblIssues.Add(issue);
//        IDb.SaveChanges();
//        return RedirectToAction("Index");



//    }
//    return View(issue);






//}

//    }
//}






////        public ActionResult Details(int id)
////        {
////            return View();
////        }

////        // GET: Issue/Create
////        public ActionResult Create()
////        {
////            return View();
////        }

////        // POST: Issue/Create
////        [HttpPost]
////        public ActionResult Create(FormCollection collection)
////        {
////            try
////            {
////                // TODO: Add insert logic here

////                return RedirectToAction("Index");
////            }
////            catch
////            {
////                return View();
////            }
////        }

////        // GET: Issue/Edit/5
////        public ActionResult Edit(int id)
////        {
////            return View();
////        }

////        // POST: Issue/Edit/5
////        [HttpPost]
////        public ActionResult Edit(int id, FormCollection collection)
////        {
////            try
////            {
////                // TODO: Add update logic here

////                return RedirectToAction("Index");
////            }
////            catch
////            {
////                return View();
////            }
////        }

////        // GET: Issue/Delete/5
////        public ActionResult Delete(int id)
////        {
////            return View();
////        }

////        // POST: Issue/Delete/5
////        [HttpPost]
////        public ActionResult Delete(int id, FormCollection collection)
////        {
////            try
////            {
////                // TODO: Add delete logic here

////                return RedirectToAction("Index");
////            }
////            catch
////            {
////                return View();
////            }
////        }
////    }
////}
