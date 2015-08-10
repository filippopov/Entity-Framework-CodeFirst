using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Model;
using StudentSystemData;

namespace StudentSystem.ConsoleClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new StudentSystemContext();
            
            //Task 3.1
            var homeworks = context.Homeworks.Select(h => new
            {
                h.Student.Name,
                h.ContentTtype,
                h.Content
            });
            foreach (var homework in homeworks)
            {
                Console.WriteLine(homework.Name+", "+homework.ContentTtype+", "+homework.Content);
            }
            Console.WriteLine();
            //Task 3.2

            var courses = context.Courses.OrderBy(c => c.StartDate)
                .ThenBy(c => c.EndDate)
                .Select(c => new
                {
                    c.Name,
                    c.Description,
                    ResurseName = c.Resources.Select(r=>r.Name)
                });

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name + ", " + course.Description + ", " + course.ResurseName);
                
            }
            Console.WriteLine();

            //Task 3.3
            //With 5 dont work try with Count 1,2 or 3
            var coursesAndRes = context.Courses.Where(c => c.Resources.Count > 5)
                .OrderByDescending(c => c.Resources.Count)
                .ThenBy(c => c.StartDate).Select(c => new
                {
                    c.Name,
                    Count=c.Resources.Count
                });

            foreach (var c in coursesAndRes)
            {
                Console.WriteLine(c.Name+", "+c.Count);
            }
            Console.WriteLine();

            //Task 3.4

            var coursesStudents = context.Courses.Where(c => c.StartDate >= new DateTime(2015, 1, 1))
                .Select(c => new
                {
                    c.Name,
                    c.StartDate,
                    c.EndDate,
                    //Count = c.Students.Count,
                    //Duration = c.EndDate - c.StartDate

                });
            foreach (var coursesStu in coursesStudents)
            {
                Console.WriteLine(coursesStu.Name+", "+coursesStu.StartDate+", "+coursesStu.EndDate);
            }
            Console.WriteLine();

            //Task 3.5

            var students = context.Students.Select(s => new
            {
                s.Name,
                NumberOfCourses = s.Courses.Count(),
                TotolPrice = s.Courses.Sum(c => c.Price),
                Avg = s.Courses.Average(c => c.Price)
            }).OrderByDescending(s => s.TotolPrice).ThenByDescending(s => s.Avg);

            //foreach (var s in students)
            //{
            //    Console.WriteLine(s.Name+", "+s.NumberOfCourses);
            //}
        }
    }
}
