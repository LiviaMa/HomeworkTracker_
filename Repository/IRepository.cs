using HomeworkTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker.Repository
{
   public interface IRepository<T>
    {
        void Add(string username, string password);
        T GetUserByUsername(string username);
        List<T> GetAll();

    }
}
