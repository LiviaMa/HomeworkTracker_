using HomeworkTracker.Models;
using HomeworkTracker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkTracker.Controllers
{
    public class UserController : Controller
    {
        IRepository<User> repository;
        // GET: User
        public UserController()
        {
            repository = new InMemoryUserRepository();
        }
        
        public ActionResult Register()
        {
            var user = new User();
            return View();
        }
        [HttpPost]
        public ActionResult Register(string username, string password)
        {
           
            repository.Add(username, password);
            //repository.GetUserByUsername(username);
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            return View();
        }
    }
}