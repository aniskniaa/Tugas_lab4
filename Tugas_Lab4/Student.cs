using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab4
{
    class Student : Person
    {
        public string StudentId { get; set; }
        public string Subject { get; set; }

        public Student(string Name, int Age, string TeacherId, string Subject) : base(Name, Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.StudentId = StudentId;
            this.Subject = Subject;
        }
    }

}