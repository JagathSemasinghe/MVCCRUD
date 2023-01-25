using MVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;

namespace MVCCRUD.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index(string Sorting_Order, string Search_Data, string Filter_Value, int? Page_No)
        {
            PersonContext cs = new PersonContext();
            List<Address>MyAddress = cs.Addresses.ToList();
           

            ViewBag.CurrentSortOrder = Sorting_Order;
            ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "PersonFname" : "";
            ViewBag.SortingDate = Sorting_Order == "PersonFname" ? "PersonEmail" : "PersonDateofbirth";

            if (Search_Data != null)
            {
                Page_No = 1;
            }
            else
            {
                Search_Data = Filter_Value;
            }

            ViewBag.FilterValue = Search_Data;

            var Person = from tblPerson in db.MVCCRUDDB select tblPerson;

            if (!String.IsNullOrEmpty(Search_Data))
            {
                Person = Person.Where(tblPerson => Person.PersonFname.ToUpper().Contains(Search_Data.ToUpper())
                    || Person.PersonLname.ToUpper().Contains(Search_Data.ToUpper()));
            }
            switch (Sorting_Order)
            {
                case "PersonFname":
                    Person = Person.OrderByDescending(tblPerson => tblPerson.PersonFname);
                    break;
                case "PersonEmail":
                    Person = Person.OrderBy(tblPerson => tblPerson.PersonEmail);
                    break;
                case "PersonDateofbirth":
                    Person = Person.OrderByDescending(tblPerson => tblPerson.PersonDateofbirth);
                    break;
                default:
                    Person = Person.OrderBy(tblPerson => tblPerson.PersonFname);
                    break;
            }

            int Size_Of_Page = 4;
            int No_Of_Page = (Page_No ?? 1);
            return View(Person.ToPagedList(No_Of_Page, Size_Of_Page));
        }

    }

   
}