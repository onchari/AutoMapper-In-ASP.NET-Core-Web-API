﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMappers
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Address Address { get; set; }
    }
}
