using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular_School.DAL.Entities;
using Angular_School.BAL;
using System.Web.Http;

namespace Angular_School.Controllers
{
    [RoutePrefix("api/Teachers")]
    public class TeacherController:ApiController
    {
        TeacherManager _manager;
        public TeacherController()
        {
            _manager = new TeacherManager();
        }
        [Route("GetAllTeachers")]
        public List<Teacher> GetAllTeachers()
        {
            return _manager.GetAllTeachers();
        }
        [Route("GetAllSubjects")]
        public List<Subject> GetAllSubjects()
        {
            return _manager.GetAllSubjects();
        }
    }
}