using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio3.Class
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return ($"The student {Name} has the email {Email}");
        }
    }
}
