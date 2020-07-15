using HomeworkTracker.Models;
using HomeworkTracker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkTracker.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        IRepository<Student> repo;

        public StudentController(IRepository<Student> repo)
        {
            this.repo = repo;
        }

        public ActionResult AddStudent()
        {
            var student = new Student();
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(string username, string link)
        {
            repo.Add(username, link);
            return View();
        }

        public ActionResult DisplayStudent(string username)
        {
            repo.GetUserByUsername(username);
            return View();
        }

        public ActionResult List()
        {
            return View(repo.GetAll());
        }

    }
}