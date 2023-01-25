using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCRUD.Models
{
    [Table("tblEmail")]
    public class Email

    {
        public int EmailId { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string Emailattach { get; set; }
        public DateTime EmailDateTime { get; set; }
    }
}