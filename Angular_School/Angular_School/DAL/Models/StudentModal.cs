using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular_School.DAL.Models;
using Angular_School.DAL.Context;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular_School.DAL.Entities;

namespace Angular_School.DAL.Models
{
    public class StudentModal:IDisposable
    {
        SchoolDbContext _context;
        void IDisposable.Dispose()
        {

        }
        public  List<Student> GetAllStudent()
        {
            using (_context = new SchoolDbContext())
            {
                try
                {
                    return _context.Students.OrderByDescending(x => x.EnrollmentNumber).ToList();
                }
                catch (Exception e)
                {
                    return null;
                }               
            }            
        }
        public Student GetStudentByEnrollmentNumber(int enrollmentNumber)
        {
            using(_context = new SchoolDbContext())
            {
                try
                {
                    return _context.Students.FirstOrDefault(student => student.EnrollmentNumber == enrollmentNumber);
                }
                catch(Exception e)
                {
                    return null;
                }
            }
        }
        public List<Student> GetStudentByClass(string selectedClass)
        {
            using(_context = new SchoolDbContext())
            {
                try
                {
                    return _context.Students.Where(x => x.Class == selectedClass).ToList();
                }
                catch(Exception e)
                {
                    return null;
                }                
            }
        }
        public bool AddStudent(Student student)
        {
            using(_context = new SchoolDbContext())
            {
                try
                {
                    _context.Students.Add(student);
                    _context.SaveChanges();
                }
                catch(Exception e)
                {
                    return false;
                }
                return true;
            }            
        }
        public bool EditStudent(int studentId,Student student)
        {
            using(_context = new SchoolDbContext())
            {
                try
                {
                    Student existingStudent = _context.Students.FirstOrDefault(x => x.EnrollmentNumber == studentId);
                    existingStudent.EnrollmentNumber = student.EnrollmentNumber;
                    existingStudent.Name = student.Name;
                    existingStudent.FatherName = student.FatherName;
                    existingStudent.MotherName = student.MotherName;
                    existingStudent.Gender = student.Gender;
                    existingStudent.DateOfBirth = student.DateOfBirth;
                    existingStudent.Class = student.Class;
                    existingStudent.Address = student.Address;
                    existingStudent.ContactNumber = student.ContactNumber;
                    existingStudent.AddmissionDate = student.AddmissionDate;
                    existingStudent.Status = student.Status;
                    _context.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
    }
}