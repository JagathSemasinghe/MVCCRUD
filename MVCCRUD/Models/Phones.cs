using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCRUD.Models
{
    [Table("tblPhone")]
    public class Phone
    {
        public int PhoneId { get; set; }
        public int PhoneNumber { get; set; }
    }
}