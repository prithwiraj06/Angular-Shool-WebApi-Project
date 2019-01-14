using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Angular_School.DAL.Entities
{
    [Table("tblStudents")]
    public class Student
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int EnrollmentNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }       
        public string ContactNumber { get; set; }
        public bool Status { get; set; }
        public string AddmissionDate { get; set; }
    }
}