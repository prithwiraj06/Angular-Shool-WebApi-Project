using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Angular_School.DAL.Entities
{
    [Table("tblTeachers")]
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string PrimarySubject { get; set; }
        public string SecondarySubject1 { get; set; }
        public string SecondarySubject2 { get; set; }
        public bool Status { get; set; }
    }
}