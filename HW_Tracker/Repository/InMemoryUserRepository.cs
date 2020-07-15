using HomeworkTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkTracker.Repository
{
    public class InMemoryUserRepository:IRepository<User>
    {
        List<User> allUsers = new List<User>();
        public void Add(string username, string password)
        {
            var user = new User();
            user.EmailAddress = username;
            user.Password = password;
            allUsers.Add(user);
        }
       public User GetUserByUsername(string username)
        {
            foreach (User user in allUsers)
            {
                if (username == user.EmailAddress)
                {
                    return user;
                }
            }
            return null;
        }
        public List<User> GetAll()
        {
            return allUsers;
        }
    }
}