using StudentSystem.Model;
using StudentSystemData.Migrations;

namespace StudentSystemData
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentSystemContext : DbContext
    {
        
        public StudentSystemContext()
            : base("name=StudentSystemContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
        }

        public IDbSet<Student> Students { get; set; }
        public IDbSet<Resource> Resources { get; set; }
        public IDbSet<Homework> Homeworks { get; set; }
        public IDbSet<Course> Courses { get; set; }
       
    }

    
}