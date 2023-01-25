using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCRUD.Models
{
    [Table("tblPerson")]
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonFname { get; set; }
        public string PersonLname { get; set; }
        public string PersonEmail { get; set; }
        public string PersonSsn { get; set; }
        public Nullable<System.DateTime> PersonDateofbirth { get; set; }
    }
}