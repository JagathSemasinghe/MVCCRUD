using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCRUD
{
    using System;
    using System.Collections.Generic;

    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeFname { get; set; }
        public string EmployeeLname { get; set; }
        public string EmployeeMobile { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeSsn { get; set; }
        public Nullable<System.DateTime> EmployeeDateofbirth { get; set; }
        public string EmployeeAddress { get; set; }
    }
}
