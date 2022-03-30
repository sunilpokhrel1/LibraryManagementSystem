using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace LibraryManagementSystem.Extended_Model
{
    public class ViewModel
    {
        //public int StudentId { get; set; }
        //public string StudentName { get; set; }
        //public int BookId { get; set; }
        //public string BookName { get; set; }
        //public Nullable<System.DateTime> IssueDate { get; set; }

        //public virtual IssueDetail IssueDetail { get; set; }

        public IEnumerable<IssueMaster> IssueMasters { get; set; }
        public IEnumerable<IssueDetail> IssueDetails { get; set; }


        //public IssueMaster  IssueMasters { get; set; }
        //public IssueDetail IssueDetails { get; set; }


    }
}