using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public partial class tblBook
    {


        public class tblBookMetaData
        {

            [DisplayName("Book Name")]
            public string BookName { get; set; }
        }
    }
}