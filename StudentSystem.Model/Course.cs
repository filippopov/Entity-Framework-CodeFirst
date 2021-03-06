﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Model
{
    public class Course
    {
        private ICollection<Resource> resources;
        private ICollection<Student> students;
        private ICollection<Homework> homeworks;

        public Course()
        {
            this.resources=new HashSet<Resource>();
            this.students=new HashSet<Student>();
            this.homeworks=new HashSet<Homework>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Resource> Resources
        {
            get { return this.resources; }
            set { this.resources = value; }
        }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }
    }
}
