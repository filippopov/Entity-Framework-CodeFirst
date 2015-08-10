using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Model
{
    public class Resource
    {
        private ICollection<Licenses> licenseses;

        public Resource()
        {
            this.licenseses=new HashSet<Licenses>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public TypeOfResource TypeOfResource { get; set; }
        public string URL { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<Licenses> Licenses
        {
            get { return this.licenseses; }
            set { this.licenseses = value; }
        }
    }
}
