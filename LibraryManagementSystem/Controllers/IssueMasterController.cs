using LibraryManagementSystem.Extended_Model;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class IssueMasterController : Controller
    {
        private readonly LibraryDatabaseEntities1 db = new LibraryDatabaseEntities1();



        // GET: IssueMaster
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult IssueBook(IssueMaster issueMaster )
        {
            bool status = false;
           

            var isValidModel = TryUpdateModel(issueMaster);
            if (isValidModel)
            {
                using (LibraryDatabaseEntities1 dc = new LibraryDatabaseEntities1())
                {
                   

                    dc.IssueMasters.Add(issueMaster);
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }

        public ActionResult Report()
        {
            //List<IssueMaster> issuemaster = db.IssueMasters.ToList();
            ////List<IssueDetail> issuedetail = db.IssueDetails.ToList();

            //ViewModel viewModel = new ViewModel();

            //List<ViewModel> viewModelList = issuemaster.Select(x => new ViewModel { StudentId = x.StudentId, StudentName = x.StudentName, BookId=x.s }).ToList();
            ////List<ViewModel> viewModelList2 = issuedetail.Select(x => new ViewModel { BookId = x.BookId, BookName = x.BookName, IssueDate=x.IssueDate }).ToList();


            //return View(viewModelList);


            var tables = new ViewModel
            {
                IssueMasters = db.IssueMasters.ToList(),
                IssueDetails = db.IssueDetails.ToList(),
            };
            return View(tables);


        }

        public ActionResult Report2()
        {

            List<IssueMaster> issuemaster = db.IssueMasters.ToList();
            List<IssueDetail> issuedetail = db.IssueDetails.ToList();

            var multipletable = (from  IM in issuemaster
                                join ID in issuedetail on  
                                IM.IssueMasterId equals ID.IssueMasterId
                                select new
                                {
                                    IM.StudentId, IM.StudentName, ID.BookId, ID.BookName, ID.IssueDate


                                }).ToList();



            return View(multipletable);



        }




    }


}