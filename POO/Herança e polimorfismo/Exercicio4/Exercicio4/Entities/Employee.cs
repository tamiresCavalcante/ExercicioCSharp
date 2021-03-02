using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hour { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hour, double valueperhour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valueperhour;
        }

        public virtual double Payment()
        {
            return Hour * ValuePerHour;
        }
    }
}
