using HomeworkTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkTracker.Repository
{
    public class InMemoryStudentRepository:IRepository<Student>
    {
        List<Student> allStudents = new List<Student>();
        public void Add(string id, string username)
        {
            var student = new Student();
            student.Id = id;
            student.Name = username;
            allStudents.Add(student);
        }
        public Student GetUserByUsername(string username)
        {
            foreach (Student student in allStudents)
            {
                if (username == student.Name)
                {
                    return student;
                }
            }
            return null;
        }
        public List<Student> GetAll()
        {
            return allStudents;
        }
    }
}