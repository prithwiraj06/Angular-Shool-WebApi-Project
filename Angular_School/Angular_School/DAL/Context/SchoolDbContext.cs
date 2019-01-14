using System.Data.Entity;
using Angular_School.DAL.Entities;

namespace Angular_School.DAL.Context
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext():base("Angular_School_DB")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}