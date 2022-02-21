using System;
using System.Collections.Generic;

namespace Lesson21.Models
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public List<Pets> Pets { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
            Pets = new List<Pets>();
        }
    }
}
