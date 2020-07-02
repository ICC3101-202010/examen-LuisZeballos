using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Person
    {
        private string name;
        private int age;
        private string nation;
        private int salary;

        public Person(string name, int age, string nation, int salary)
        {
            this.name = name;
            this.age = age;
            this.nation = nation;
            this.salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Nation { get => nation; set => nation = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
