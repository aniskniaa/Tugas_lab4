﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab4
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0} and age : {1}", Name, Age);
        }
    }
}
