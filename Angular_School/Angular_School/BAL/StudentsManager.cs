using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular_School.DAL.Models;
using Angular_School.DAL.Entities;
using System.Net;
using System.Net.Http;

namespace Angular_School.BAL
{
    public class StudentsManager
    {
        StudentModal _entity;        
        public List<Student> GetAllStudent()
        {
            using(_entity = new StudentModal())
            {
                return _entity.GetAllStudent();
            }
            
        }
        public Student GetStudentByEnrollmentNumber(int enrollmentNumber)
        {
            using(_entity = new StudentModal())
            {
                return _entity.GetStudentByEnrollmentNumber(enrollmentNumber);
            }
        }
        public List<Student> GetStudentByClass(string selectedClass)
        {
            using(_entity = new StudentModal())
            {
                return _entity.GetStudentByClass(selectedClass);
            }
        }
        public bool AddStudent(Student student)
        {
            using (_entity = new StudentModal())
            {
                return _entity.AddStudent(student);
            }
        }
        public bool  EditStudent(int studentId, Student student)
        {
            using(_entity = new StudentModal())
            {
                return _entity.EditStudent(studentId, student);
            }            
        }
    }
}