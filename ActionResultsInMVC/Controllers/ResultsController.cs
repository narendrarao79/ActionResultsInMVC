using ActionResultsInMVC.Models;
using System.Collections.Generic;
using System.Text;
using System;
using System.Web.Mvc;
namespace ActionResultsInMVC.Controllers
{
    public class ResultsController : Controller
    {
        public ViewResult index()
        {
            return View();
        }
        public JsonResult GetEmployees()
        {
            Employee e1 = new Employee { Id = 101, Name = "Scott", Job = "CEO", Salary = 25000, Status = true };
            Employee e2 = new Employee { Id = 102, Name = "Smith", Job = "President", Salary = 22000, Status = true };
            Employee e3 = new Employee { Id = 103, Name = "Parker", Job = "Manager", Salary = 18000, Status = true };
            Employee e4 = new Employee { Id = 104, Name = "John", Job = "Salesman", Salary = 10000, Status = true };
            Employee e5 = new Employee { Id = 105, Name = "David", Job = "Clerk", Salary = 5000, Status = true };
            Employee e6 = new Employee { Id = 106, Name = "Maria", Job = "Analyst", Salary = 12000, Status = true };
            List<Employee> Emps = new List<Employee> { e1, e2, e3, e4, e5, e6 };
            return Json(Emps, JsonRequestBehavior.AllowGet);
        }
        public FileResult DownloadPdf()
        {
            return File("~/Downloads/Resume.pdf", "application/pdf");
        }
        public FileResult DownloadWord()
        {
            return File("~/Downloads/Project Title.doc", "application/msword");
        }
        public RedirectResult OpenFaceBook()
        {
            return Redirect("https://facebook.com");
        }
        public RedirectResult OpenTwitter()
        {
            return Redirect("https://twitter.com");
        }
        public string SendDate1()
        {
            return "Current Date: " + DateTime.Now.ToString();
        }
        public ContentResult SendDate2()
        {
            return Content("Current Date: " + DateTime.Now.ToString());
        }
        public string SayHello1()
        {
            return "नमस्ते आप कैसे हैं";
        }
        public ContentResult SayHello2()
        {
            return Content("नमस्ते आप कैसे हैं", "text/plain", Encoding.Unicode);
        }
        public JavaScriptResult AlertUser()
        {
            return JavaScript("alert('Hello, how are you.');");
        }
        public void ReturnEmpty1()
        {
            string str = ("Hello World").ToUpper();
        }
        public EmptyResult ReturnEmpty2()
        {
            return new EmptyResult();
        }
    }
}