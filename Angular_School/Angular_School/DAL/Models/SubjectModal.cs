using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular_School.DAL.Entities;
using Angular_School.DAL.Context;
namespace Angular_School.DAL.Models
{
    public class SubjectModal : IDisposable
    {
        SchoolDbContext _Context;
        public void Dispose()
        {
            
        }
        public List<Subject> GetAllSubjects()
        {
            using(_Context = new SchoolDbContext())
            {
                return _Context.Subjects.ToList();
            }
        }
    }
}