using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Extended_Model
{
    public class MultipleTable
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }

        public DateTime IssueDate { get; set; }

    }
}