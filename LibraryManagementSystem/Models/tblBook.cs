//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBook
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookCategory { get; set; }
        public string BookAuthor { get; set; }
        public int BookNumber { get; set; }
        public string Description { get; set; }
        public string BookPrice { get; set; }
        public string AddedDate { get; set; }
    }
}