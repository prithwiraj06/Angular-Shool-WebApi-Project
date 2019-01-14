using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular_School.DAL.Entities;
using Angular_School.DAL.Context;

namespace Angular_School.DAL.Models
{
    public class TeacherModal : IDisposable
    {
        SchoolDbContext _Context;
        public void Dispose()
        {
            
        }
        public List<Teacher> GetAllTeachers()
        {
            using(_Context = new SchoolDbContext())
            {
                try
                {
                    return _Context.Teachers.OrderByDescending(x => x.TeacherId).ToList();
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
    }
}