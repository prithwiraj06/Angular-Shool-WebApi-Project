using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular_School.DAL.Entities;
using Angular_School.DAL.Models;
namespace Angular_School.BAL
{
    public class TeacherManager
    {
        TeacherModal _teacherModal;
        SubjectModal _subjectModal;
        public List<Teacher> GetAllTeachers()
        {
            using(_teacherModal = new TeacherModal())
            {
                return _teacherModal.GetAllTeachers();
            }
        }
        public List<Subject> GetAllSubjects()
        {
            using(_subjectModal = new SubjectModal())
            {
                return _subjectModal.GetAllSubjects();
            }
        }
    }
}