using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCRUD.Models
{
    [Table("tblAddress")]
    public class Address
    {
        public int AddressesId { get; set; }
        public int AddressesName { get; set; }
    }
}