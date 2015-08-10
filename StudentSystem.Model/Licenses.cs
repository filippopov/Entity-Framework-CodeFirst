﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Model
{
    public class Licenses
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ResourceId { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
