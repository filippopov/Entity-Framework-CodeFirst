using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Model
{
    public class Homework
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public ContentTtype ContentTtype { get; set; }
        public DateTime SubmitionDate { get; set; }

        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
