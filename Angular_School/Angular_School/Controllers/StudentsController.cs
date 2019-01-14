using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Angular_School.BAL;
using Angular_School.DAL.Entities;

namespace Angular_School.Controllers
{
    [RoutePrefix("api/Students")]
    public class StudentsController : ApiController
    {
        StudentsManager studentManager;
        public StudentsController()
        {
            studentManager = new StudentsManager();
        }
        [HttpGet]
        [Route("GetAllStudents")]
        public List<Student> GetAllStudent()
        {
            return studentManager.GetAllStudent();
        }
        [HttpGet]
        [Route("GetStudentByEnrollmentNumber/{enrollmentNumber}")]
        public Student GetStudentByEnrollmentNumber(int enrollmentNumber)
        {
            return studentManager.GetStudentByEnrollmentNumber(enrollmentNumber);
        }
        [HttpGet]
        [Route("GetStudentByClass/{selectedClass}")]
        public List<Student> GetStudentByClass(string selectedClass)
        {
            return studentManager.GetStudentByClass(selectedClass);
        }
        [HttpPost]
        [Route("AddStudent")]
        public bool AddStudent([FromBody]Student student)
        {
            return studentManager.AddStudent(student);
        }
        [HttpPut]
        [Route("EditStudent/{studentId}")]
        public bool EditStudent(int studentId, [FromBody]Student student)
        {
            return studentManager.EditStudent(studentId, student);
        }
    }
}