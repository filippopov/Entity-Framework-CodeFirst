using System.Collections.Generic;
using StudentSystem.Model;

namespace StudentSystemData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystemData.StudentSystemContext>
    {
        public Configuration()
        {
            //AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "StudentSystemData.StudentSystemContext";
        }

        protected override void Seed(StudentSystemData.StudentSystemContext context)
        {
            
            //for (int i = 0; i < 10; i++)
            //{
                
            //    context.Students.Add(new Student()
            //    {
            //        BirthDay = DateTime.Now,
            //        Name = "Fili"+i,
            //        RegistrationDate = DateTime.Now,
            //        PhoneNumber = "232432342"+i,
            //    });
               
            //    context.Homeworks.Add(new Homework()
            //    {
            //        Content = "Hi" + i,
            //        ContentTtype = ContentTtype.Application,
            //        CourseId = i,
            //        StudentId = i,
            //        SubmitionDate = DateTime.Now
            //    });
                
            //    context.Courses.Add(new Course()
            //    {
            //        Description = "Hi" + i,
            //        EndDate = DateTime.Now,
            //        Price = i,
            //        Name = "Hi" + i,
            //        StartDate = DateTime.Now
            //    });
              
            //    context.Resources.Add(new Resource()
            //    {
            //        CourseId = i,
            //        Name = "hi" + i,
            //        TypeOfResource = TypeOfResource.Video,
            //        URL = "dsfsfsfs.sfwefw" + i,
            //    });
            //    context.SaveChanges();
            //}
            
        }
    }
}
