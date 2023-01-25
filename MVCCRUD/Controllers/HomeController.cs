using MVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers

{

  
    public class HomeController : Controller
    {
        MVCCRUDDBContext _context = new MVCCRUDDBContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee model)
        {
            _context.Employees.Add(model);
            _context.SaveChanges();
             ViewBag.Message = "Data Insert Successfully";
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == model.EmployeeId).FirstOrDefault();
            if (data != null)
            {
                data.EmployeeFname = model.EmployeeFname;
                data.EmployeeLname = model.EmployeeLname;
                data.EmployeeMobile = model.EmployeeMobile;
                data.EmployeeEmail = model.EmployeeEmail;
                data.EmployeeSsn = model.EmployeeSsn;
                data.EmployeeDateofbirth = model.EmployeeDateofbirth;
                data.EmployeeAddress = model.EmployeeAddress;
                _context.SaveChanges();
            }
            return RedirectToAction("index");
        }
        public ActionResult Detail(int id)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(data);
        }
        public ActionResult Delete(int id)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            _context.Employees.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Record Delete Successfully";
            return RedirectToAction("index");
        }

        public string OpenPopup()
        {
            return ("Detail"); ;
        }
    }
}